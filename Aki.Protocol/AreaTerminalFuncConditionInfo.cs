using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200010D RID: 269
	public sealed class AreaTerminalFuncConditionInfo : IMessage<AreaTerminalFuncConditionInfo>, IMessage, IEquatable<AreaTerminalFuncConditionInfo>, IDeepCloneable<AreaTerminalFuncConditionInfo>, IBufferMessage
	{
		// Token: 0x06002550 RID: 9552 RVA: 0x00063A60 File Offset: 0x00061C60
		[NullableContext(1)]
		public static AreaTerminalFuncConditionInfo Create()
		{
			return new AreaTerminalFuncConditionInfo();
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x00063A67 File Offset: 0x00061C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AreaTerminalFuncConditionInfo> Parser
		{
			get
			{
				return AreaTerminalFuncConditionInfo._parser;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x00063A6E File Offset: 0x00061C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x00063A71 File Offset: 0x00061C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaTerminalFuncConditionInfo.Descriptor;
			}
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00063A78 File Offset: 0x00061C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalFuncConditionInfo()
		{
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00063A8B File Offset: 0x00061C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalFuncConditionInfo(AreaTerminalFuncConditionInfo other) : this()
		{
			this.funcId_ = other.funcId_;
			this.finishConditionIds_ = other.finishConditionIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00063AC1 File Offset: 0x00061CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalFuncConditionInfo Clone()
		{
			return new AreaTerminalFuncConditionInfo(this);
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x00063AC9 File Offset: 0x00061CC9
		// (set) Token: 0x06002558 RID: 9560 RVA: 0x00063AD1 File Offset: 0x00061CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FuncId
		{
			get
			{
				return this.funcId_;
			}
			set
			{
				this.funcId_ = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x00063ADA File Offset: 0x00061CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinishConditionIds
		{
			get
			{
				return this.finishConditionIds_;
			}
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00063AE2 File Offset: 0x00061CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaTerminalFuncConditionInfo);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00063AF0 File Offset: 0x00061CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaTerminalFuncConditionInfo other)
		{
			return other != null && (other == this || (this.FuncId == other.FuncId && this.finishConditionIds_.Equals(other.finishConditionIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00063B40 File Offset: 0x00061D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FuncId != 0)
			{
				num ^= this.FuncId.GetHashCode();
			}
			num ^= this.finishConditionIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00063B8D File Offset: 0x00061D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00063B9A File Offset: 0x00061D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00063BA4 File Offset: 0x00061DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FuncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FuncId);
			}
			this.finishConditionIds_.WriteTo(ref output, AreaTerminalFuncConditionInfo._repeated_finishConditionIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00063BF4 File Offset: 0x00061DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FuncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncId);
			}
			num += this.finishConditionIds_.CalculateSize(AreaTerminalFuncConditionInfo._repeated_finishConditionIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00063C48 File Offset: 0x00061E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AreaTerminalFuncConditionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FuncId != 0)
			{
				this.FuncId = other.FuncId;
			}
			this.finishConditionIds_.Add(other.finishConditionIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x00063C95 File Offset: 0x00061E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00063CA0 File Offset: 0x00061EA0
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
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.finishConditionIds_.AddEntriesFrom(ref input, AreaTerminalFuncConditionInfo._repeated_finishConditionIds_codec);
					}
				}
				else
				{
					this.FuncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040025BF RID: 9663
		private static readonly MessageParser<AreaTerminalFuncConditionInfo> _parser = new MessageParser<AreaTerminalFuncConditionInfo>(() => new AreaTerminalFuncConditionInfo());

		// Token: 0x040025C0 RID: 9664
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025C1 RID: 9665
		public const int FuncIdFieldNumber = 1;

		// Token: 0x040025C2 RID: 9666
		private int funcId_;

		// Token: 0x040025C3 RID: 9667
		public const int FinishConditionIdsFieldNumber = 2;

		// Token: 0x040025C4 RID: 9668
		private static readonly FieldCodec<int> _repeated_finishConditionIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040025C5 RID: 9669
		private readonly RepeatedField<int> finishConditionIds_ = new RepeatedField<int>();
	}
}
