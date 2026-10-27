using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C0 RID: 4544
	[NetMessage(EMessageId.SelectDetectionTargetResponse)]
	public sealed class SelectDetectionTargetResponse : IMessage<SelectDetectionTargetResponse>, IMessage, IEquatable<SelectDetectionTargetResponse>, IDeepCloneable<SelectDetectionTargetResponse>, IBufferMessage
	{
		// Token: 0x060183F2 RID: 99314 RVA: 0x003879D3 File Offset: 0x00385BD3
		[NullableContext(1)]
		public static SelectDetectionTargetResponse Create()
		{
			return new SelectDetectionTargetResponse();
		}

		// Token: 0x170051B0 RID: 20912
		// (get) Token: 0x060183F3 RID: 99315 RVA: 0x003879DA File Offset: 0x00385BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051B1 RID: 20913
		// (get) Token: 0x060183F4 RID: 99316 RVA: 0x003879DD File Offset: 0x00385BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectDetectionTargetResponse.Descriptor;
			}
		}

		// Token: 0x060183F5 RID: 99317 RVA: 0x003879E4 File Offset: 0x00385BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTargetResponse()
		{
		}

		// Token: 0x060183F6 RID: 99318 RVA: 0x003879EC File Offset: 0x00385BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTargetResponse(SelectDetectionTargetResponse other) : this()
		{
			this.code_ = other.code_;
			this.selectDetectionTarget_ = ((other.selectDetectionTarget_ != null) ? other.selectDetectionTarget_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060183F7 RID: 99319 RVA: 0x00387A38 File Offset: 0x00385C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTargetResponse Clone()
		{
			return new SelectDetectionTargetResponse(this);
		}

		// Token: 0x170051B2 RID: 20914
		// (get) Token: 0x060183F8 RID: 99320 RVA: 0x00387A40 File Offset: 0x00385C40
		// (set) Token: 0x060183F9 RID: 99321 RVA: 0x00387A48 File Offset: 0x00385C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x170051B3 RID: 20915
		// (get) Token: 0x060183FA RID: 99322 RVA: 0x00387A51 File Offset: 0x00385C51
		// (set) Token: 0x060183FB RID: 99323 RVA: 0x00387A59 File Offset: 0x00385C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTarget SelectDetectionTarget
		{
			get
			{
				return this.selectDetectionTarget_;
			}
			set
			{
				this.selectDetectionTarget_ = value;
			}
		}

		// Token: 0x060183FC RID: 99324 RVA: 0x00387A62 File Offset: 0x00385C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectDetectionTargetResponse);
		}

		// Token: 0x060183FD RID: 99325 RVA: 0x00387A70 File Offset: 0x00385C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectDetectionTargetResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.SelectDetectionTarget, other.SelectDetectionTarget) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060183FE RID: 99326 RVA: 0x00387AC0 File Offset: 0x00385CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.selectDetectionTarget_ != null)
			{
				num ^= this.SelectDetectionTarget.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060183FF RID: 99327 RVA: 0x00387B1B File Offset: 0x00385D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018400 RID: 99328 RVA: 0x00387B28 File Offset: 0x00385D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018401 RID: 99329 RVA: 0x00387B34 File Offset: 0x00385D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this.selectDetectionTarget_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.SelectDetectionTarget);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018402 RID: 99330 RVA: 0x00387B8C File Offset: 0x00385D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.selectDetectionTarget_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelectDetectionTarget);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018403 RID: 99331 RVA: 0x00387BE4 File Offset: 0x00385DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectDetectionTargetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.selectDetectionTarget_ != null)
			{
				if (this.selectDetectionTarget_ == null)
				{
					this.SelectDetectionTarget = new SelectDetectionTarget();
				}
				this.SelectDetectionTarget.MergeFrom(other.SelectDetectionTarget);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018404 RID: 99332 RVA: 0x00387C4C File Offset: 0x00385E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018405 RID: 99333 RVA: 0x00387C58 File Offset: 0x00385E58
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
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.selectDetectionTarget_ == null)
						{
							this.SelectDetectionTarget = new SelectDetectionTarget();
						}
						input.ReadMessage(this.SelectDetectionTarget);
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FC2 RID: 36802
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FC3 RID: 36803
		public const int CodeFieldNumber = 1;

		// Token: 0x04008FC4 RID: 36804
		private ErrorCode code_;

		// Token: 0x04008FC5 RID: 36805
		public const int SelectDetectionTargetFieldNumber = 14;

		// Token: 0x04008FC6 RID: 36806
		private SelectDetectionTarget selectDetectionTarget_;
	}
}
