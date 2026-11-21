using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200017B RID: 379
	[NetMessage(EMessageId.BattlePassTaskTakeRequest)]
	public sealed class BattlePassTaskTakeRequest : IMessage<BattlePassTaskTakeRequest>, IMessage, IEquatable<BattlePassTaskTakeRequest>, IDeepCloneable<BattlePassTaskTakeRequest>, IBufferMessage
	{
		// Token: 0x06002E60 RID: 11872 RVA: 0x00077C9C File Offset: 0x00075E9C
		[NullableContext(1)]
		public static BattlePassTaskTakeRequest Create()
		{
			return new BattlePassTaskTakeRequest();
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x00077CA3 File Offset: 0x00075EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06002E62 RID: 11874 RVA: 0x00077CA6 File Offset: 0x00075EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTaskTakeRequest.Descriptor;
			}
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00077CAD File Offset: 0x00075EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskTakeRequest()
		{
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x00077CC0 File Offset: 0x00075EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskTakeRequest(BattlePassTaskTakeRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00077CEA File Offset: 0x00075EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskTakeRequest Clone()
		{
			return new BattlePassTaskTakeRequest(this);
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06002E66 RID: 11878 RVA: 0x00077CF2 File Offset: 0x00075EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x00077CFA File Offset: 0x00075EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTaskTakeRequest);
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x00077D08 File Offset: 0x00075F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTaskTakeRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x00077D3C File Offset: 0x00075F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x00077D70 File Offset: 0x00075F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00077D7D File Offset: 0x00075F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x00077D86 File Offset: 0x00075F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, BattlePassTaskTakeRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00077DB0 File Offset: 0x00075FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(BattlePassTaskTakeRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x00077DE9 File Offset: 0x00075FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTaskTakeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x00077E17 File Offset: 0x00076017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x00077E20 File Offset: 0x00076020
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, BattlePassTaskTakeRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x040028C7 RID: 10439
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028C8 RID: 10440
		public const int IdsFieldNumber = 1;

		// Token: 0x040028C9 RID: 10441
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040028CA RID: 10442
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
