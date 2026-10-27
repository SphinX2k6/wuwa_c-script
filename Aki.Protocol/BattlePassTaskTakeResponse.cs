using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000179 RID: 377
	[NetMessage(EMessageId.BattlePassTaskTakeResponse)]
	public sealed class BattlePassTaskTakeResponse : IMessage<BattlePassTaskTakeResponse>, IMessage, IEquatable<BattlePassTaskTakeResponse>, IDeepCloneable<BattlePassTaskTakeResponse>, IBufferMessage
	{
		// Token: 0x06002DFB RID: 11771 RVA: 0x00076A51 File Offset: 0x00074C51
		[NullableContext(1)]
		public static BattlePassTaskTakeResponse Create()
		{
			return new BattlePassTaskTakeResponse();
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x00076A58 File Offset: 0x00074C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x00076A5B File Offset: 0x00074C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTaskTakeResponse.Descriptor;
			}
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x00076A62 File Offset: 0x00074C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskTakeResponse()
		{
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x00076A75 File Offset: 0x00074C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskTakeResponse(BattlePassTaskTakeResponse other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x00076AAB File Offset: 0x00074CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskTakeResponse Clone()
		{
			return new BattlePassTaskTakeResponse(this);
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x00076AB3 File Offset: 0x00074CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x00076ABB File Offset: 0x00074CBB
		// (set) Token: 0x06002E03 RID: 11779 RVA: 0x00076AC3 File Offset: 0x00074CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x00076ACC File Offset: 0x00074CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTaskTakeResponse);
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x00076ADC File Offset: 0x00074CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTaskTakeResponse other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x00076B2C File Offset: 0x00074D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x00076B7F File Offset: 0x00074D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x00076B8C File Offset: 0x00074D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x00076B98 File Offset: 0x00074D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.ids_.WriteTo(ref output, BattlePassTaskTakeResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x00076BE8 File Offset: 0x00074DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(BattlePassTaskTakeResponse._repeated_ids_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00076C3C File Offset: 0x00074E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTaskTakeResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x00076C89 File Offset: 0x00074E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x00076C94 File Offset: 0x00074E94
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
				if (num != 24U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, BattlePassTaskTakeResponse._repeated_ids_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002857 RID: 10327
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002858 RID: 10328
		public const int IdsFieldNumber = 13;

		// Token: 0x04002859 RID: 10329
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(106U);

		// Token: 0x0400285A RID: 10330
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x0400285B RID: 10331
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400285C RID: 10332
		private ErrorCode errorCode_;
	}
}
