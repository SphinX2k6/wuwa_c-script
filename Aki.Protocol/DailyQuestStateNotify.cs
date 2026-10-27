using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200032A RID: 810
	[NetMessage(EMessageId.DailyQuestStateNotify)]
	public sealed class DailyQuestStateNotify : IMessage<DailyQuestStateNotify>, IMessage, IEquatable<DailyQuestStateNotify>, IDeepCloneable<DailyQuestStateNotify>, IBufferMessage
	{
		// Token: 0x06005146 RID: 20806 RVA: 0x000C5B2B File Offset: 0x000C3D2B
		[NullableContext(1)]
		public static DailyQuestStateNotify Create()
		{
			return new DailyQuestStateNotify();
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06005147 RID: 20807 RVA: 0x000C5B32 File Offset: 0x000C3D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06005148 RID: 20808 RVA: 0x000C5B35 File Offset: 0x000C3D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestStateNotify.Descriptor;
			}
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x000C5B3C File Offset: 0x000C3D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestStateNotify()
		{
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x000C5B5A File Offset: 0x000C3D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestStateNotify(DailyQuestStateNotify other) : this()
		{
			this.getReward_ = other.getReward_.Clone();
			this.allQuest_ = other.allQuest_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x000C5B95 File Offset: 0x000C3D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestStateNotify Clone()
		{
			return new DailyQuestStateNotify(this);
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x0600514C RID: 20812 RVA: 0x000C5B9D File Offset: 0x000C3D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GetReward
		{
			get
			{
				return this.getReward_;
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x0600514D RID: 20813 RVA: 0x000C5BA5 File Offset: 0x000C3DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> AllQuest
		{
			get
			{
				return this.allQuest_;
			}
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x000C5BAD File Offset: 0x000C3DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestStateNotify);
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x000C5BBC File Offset: 0x000C3DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestStateNotify other)
		{
			return other != null && (other == this || (this.getReward_.Equals(other.getReward_) && this.AllQuest.Equals(other.AllQuest) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x000C5C10 File Offset: 0x000C3E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.getReward_.GetHashCode();
			num ^= this.AllQuest.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x000C5C52 File Offset: 0x000C3E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x000C5C5F File Offset: 0x000C3E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x000C5C68 File Offset: 0x000C3E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.allQuest_.WriteTo(ref output, DailyQuestStateNotify._map_allQuest_codec);
			this.getReward_.WriteTo(ref output, DailyQuestStateNotify._repeated_getReward_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x000C5CA0 File Offset: 0x000C3EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.getReward_.CalculateSize(DailyQuestStateNotify._repeated_getReward_codec);
			num += this.allQuest_.CalculateSize(DailyQuestStateNotify._map_allQuest_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x000C5CEC File Offset: 0x000C3EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyQuestStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.getReward_.Add(other.getReward_);
			this.allQuest_.MergeFrom(other.allQuest_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x000C5D2B File Offset: 0x000C3F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x000C5D34 File Offset: 0x000C3F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 42U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.getReward_.AddEntriesFrom(ref input, DailyQuestStateNotify._repeated_getReward_codec);
					}
				}
				else
				{
					this.allQuest_.AddEntriesFrom(ref input, DailyQuestStateNotify._map_allQuest_codec);
				}
			}
		}

		// Token: 0x04003298 RID: 12952
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003299 RID: 12953
		public const int GetRewardFieldNumber = 13;

		// Token: 0x0400329A RID: 12954
		private static readonly FieldCodec<int> _repeated_getReward_codec = FieldCodec.ForInt32(106U);

		// Token: 0x0400329B RID: 12955
		private readonly RepeatedField<int> getReward_ = new RepeatedField<int>();

		// Token: 0x0400329C RID: 12956
		public const int AllQuestFieldNumber = 5;

		// Token: 0x0400329D RID: 12957
		private static readonly MapField<int, int>.Codec _map_allQuest_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x0400329E RID: 12958
		private readonly MapField<int, int> allQuest_ = new MapField<int, int>();
	}
}
