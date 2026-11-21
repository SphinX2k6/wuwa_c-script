using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000331 RID: 817
	[NetMessage(EMessageId.DailyQuestStateNotify)]
	public sealed class DailyQuestStateNotify : IMessage<DailyQuestStateNotify>, IMessage, IEquatable<DailyQuestStateNotify>, IDeepCloneable<DailyQuestStateNotify>, IBufferMessage
	{
		// Token: 0x0600521F RID: 21023 RVA: 0x000C7F1F File Offset: 0x000C611F
		[NullableContext(1)]
		public static DailyQuestStateNotify Create()
		{
			return new DailyQuestStateNotify();
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06005220 RID: 21024 RVA: 0x000C7F26 File Offset: 0x000C6126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06005221 RID: 21025 RVA: 0x000C7F29 File Offset: 0x000C6129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestStateNotify.Descriptor;
			}
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x000C7F30 File Offset: 0x000C6130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestStateNotify()
		{
		}

		// Token: 0x06005223 RID: 21027 RVA: 0x000C7F4E File Offset: 0x000C614E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestStateNotify(DailyQuestStateNotify other) : this()
		{
			this.getReward_ = other.getReward_.Clone();
			this.allQuest_ = other.allQuest_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x000C7F89 File Offset: 0x000C6189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestStateNotify Clone()
		{
			return new DailyQuestStateNotify(this);
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06005225 RID: 21029 RVA: 0x000C7F91 File Offset: 0x000C6191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GetReward
		{
			get
			{
				return this.getReward_;
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06005226 RID: 21030 RVA: 0x000C7F99 File Offset: 0x000C6199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> AllQuest
		{
			get
			{
				return this.allQuest_;
			}
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x000C7FA1 File Offset: 0x000C61A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestStateNotify);
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x000C7FB0 File Offset: 0x000C61B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestStateNotify other)
		{
			return other != null && (other == this || (this.getReward_.Equals(other.getReward_) && this.AllQuest.Equals(other.AllQuest) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x000C8004 File Offset: 0x000C6204
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

		// Token: 0x0600522A RID: 21034 RVA: 0x000C8046 File Offset: 0x000C6246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x000C8053 File Offset: 0x000C6253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x000C805C File Offset: 0x000C625C
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

		// Token: 0x0600522D RID: 21037 RVA: 0x000C8094 File Offset: 0x000C6294
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

		// Token: 0x0600522E RID: 21038 RVA: 0x000C80E0 File Offset: 0x000C62E0
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

		// Token: 0x0600522F RID: 21039 RVA: 0x000C811F File Offset: 0x000C631F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x000C8128 File Offset: 0x000C6328
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
				if (num != 50U)
				{
					if (num != 72U && num != 74U)
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

		// Token: 0x0400332F RID: 13103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003330 RID: 13104
		public const int GetRewardFieldNumber = 9;

		// Token: 0x04003331 RID: 13105
		private static readonly FieldCodec<int> _repeated_getReward_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04003332 RID: 13106
		private readonly RepeatedField<int> getReward_ = new RepeatedField<int>();

		// Token: 0x04003333 RID: 13107
		public const int AllQuestFieldNumber = 6;

		// Token: 0x04003334 RID: 13108
		private static readonly MapField<int, int>.Codec _map_allQuest_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 50U);

		// Token: 0x04003335 RID: 13109
		private readonly MapField<int, int> allQuest_ = new MapField<int, int>();
	}
}
