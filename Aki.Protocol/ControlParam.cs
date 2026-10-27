using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002EF RID: 751
	public sealed class ControlParam : IMessage<ControlParam>, IMessage, IEquatable<ControlParam>, IDeepCloneable<ControlParam>, IBufferMessage
	{
		// Token: 0x06004C2F RID: 19503 RVA: 0x000B964D File Offset: 0x000B784D
		[NullableContext(1)]
		public static ControlParam Create()
		{
			return new ControlParam();
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06004C30 RID: 19504 RVA: 0x000B9654 File Offset: 0x000B7854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ControlParam> Parser
		{
			get
			{
				return ControlParam._parser;
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06004C31 RID: 19505 RVA: 0x000B965B File Offset: 0x000B785B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06004C32 RID: 19506 RVA: 0x000B965E File Offset: 0x000B785E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ControlParam.Descriptor;
			}
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x000B9665 File Offset: 0x000B7865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlParam()
		{
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x000B966D File Offset: 0x000B786D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlParam(ControlParam other) : this()
		{
			this.controlType_ = other.controlType_;
			if (other.ParamCase == ControlParam.ParamOneofCase.TemporaryTeleportParam)
			{
				this.TemporaryTeleportParam = other.TemporaryTeleportParam.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x000B96AC File Offset: 0x000B78AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlParam Clone()
		{
			return new ControlParam(this);
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06004C36 RID: 19510 RVA: 0x000B96B4 File Offset: 0x000B78B4
		// (set) Token: 0x06004C37 RID: 19511 RVA: 0x000B96BC File Offset: 0x000B78BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlType ControlType
		{
			get
			{
				return this.controlType_;
			}
			set
			{
				this.controlType_ = value;
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06004C38 RID: 19512 RVA: 0x000B96C5 File Offset: 0x000B78C5
		// (set) Token: 0x06004C39 RID: 19513 RVA: 0x000B96DD File Offset: 0x000B78DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlTemporaryTeleportParam TemporaryTeleportParam
		{
			get
			{
				if (this.paramCase_ != ControlParam.ParamOneofCase.TemporaryTeleportParam)
				{
					return null;
				}
				return (ControlTemporaryTeleportParam)this.param_;
			}
			set
			{
				this.param_ = value;
				this.paramCase_ = ((value == null) ? ControlParam.ParamOneofCase.None : ControlParam.ParamOneofCase.TemporaryTeleportParam);
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06004C3A RID: 19514 RVA: 0x000B96F3 File Offset: 0x000B78F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlParam.ParamOneofCase ParamCase
		{
			get
			{
				return this.paramCase_;
			}
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x000B96FB File Offset: 0x000B78FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearParam()
		{
			this.paramCase_ = ControlParam.ParamOneofCase.None;
			this.param_ = null;
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x000B970B File Offset: 0x000B790B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ControlParam);
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x000B971C File Offset: 0x000B791C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ControlParam other)
		{
			return other != null && (other == this || (this.ControlType == other.ControlType && object.Equals(this.TemporaryTeleportParam, other.TemporaryTeleportParam) && this.ParamCase == other.ParamCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x000B977C File Offset: 0x000B797C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ControlType != ControlType.Unknown)
			{
				num ^= this.ControlType.GetHashCode();
			}
			if (this.paramCase_ == ControlParam.ParamOneofCase.TemporaryTeleportParam)
			{
				num ^= this.TemporaryTeleportParam.GetHashCode();
			}
			num ^= (int)this.paramCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C3F RID: 19519 RVA: 0x000B97E1 File Offset: 0x000B79E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x000B97EE File Offset: 0x000B79EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x000B97F8 File Offset: 0x000B79F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ControlType != ControlType.Unknown)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ControlType);
			}
			if (this.paramCase_ == ControlParam.ParamOneofCase.TemporaryTeleportParam)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TemporaryTeleportParam);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x000B9854 File Offset: 0x000B7A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ControlType != ControlType.Unknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ControlType);
			}
			if (this.paramCase_ == ControlParam.ParamOneofCase.TemporaryTeleportParam)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TemporaryTeleportParam);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x000B98AC File Offset: 0x000B7AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ControlParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ControlType != ControlType.Unknown)
			{
				this.ControlType = other.ControlType;
			}
			if (other.ParamCase == ControlParam.ParamOneofCase.TemporaryTeleportParam)
			{
				if (this.TemporaryTeleportParam == null)
				{
					this.TemporaryTeleportParam = new ControlTemporaryTeleportParam();
				}
				this.TemporaryTeleportParam.MergeFrom(other.TemporaryTeleportParam);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x000B9915 File Offset: 0x000B7B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x000B9920 File Offset: 0x000B7B20
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						ControlTemporaryTeleportParam controlTemporaryTeleportParam = new ControlTemporaryTeleportParam();
						if (this.paramCase_ == ControlParam.ParamOneofCase.TemporaryTeleportParam)
						{
							controlTemporaryTeleportParam.MergeFrom(this.TemporaryTeleportParam);
						}
						input.ReadMessage(controlTemporaryTeleportParam);
						this.TemporaryTeleportParam = controlTemporaryTeleportParam;
					}
				}
				else
				{
					this.ControlType = (ControlType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040030E6 RID: 12518
		private static readonly MessageParser<ControlParam> _parser = new MessageParser<ControlParam>(() => new ControlParam());

		// Token: 0x040030E7 RID: 12519
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030E8 RID: 12520
		public const int ControlTypeFieldNumber = 1;

		// Token: 0x040030E9 RID: 12521
		private ControlType controlType_;

		// Token: 0x040030EA RID: 12522
		public const int TemporaryTeleportParamFieldNumber = 2;

		// Token: 0x040030EB RID: 12523
		private object param_;

		// Token: 0x040030EC RID: 12524
		private ControlParam.ParamOneofCase paramCase_;

		// Token: 0x0200172C RID: 5932
		public enum ParamOneofCase
		{
			// Token: 0x0400C590 RID: 50576
			None,
			// Token: 0x0400C591 RID: 50577
			TemporaryTeleportParam = 2
		}
	}
}
