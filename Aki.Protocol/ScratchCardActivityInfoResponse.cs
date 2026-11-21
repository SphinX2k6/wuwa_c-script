using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D7 RID: 4567
	[NetMessage(EMessageId.ScratchCardActivityInfoResponse)]
	public sealed class ScratchCardActivityInfoResponse : IMessage<ScratchCardActivityInfoResponse>, IMessage, IEquatable<ScratchCardActivityInfoResponse>, IDeepCloneable<ScratchCardActivityInfoResponse>, IBufferMessage
	{
		// Token: 0x0601860B RID: 99851 RVA: 0x0038C445 File Offset: 0x0038A645
		[NullableContext(1)]
		public static ScratchCardActivityInfoResponse Create()
		{
			return new ScratchCardActivityInfoResponse();
		}

		// Token: 0x17005227 RID: 21031
		// (get) Token: 0x0601860C RID: 99852 RVA: 0x0038C44C File Offset: 0x0038A64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005228 RID: 21032
		// (get) Token: 0x0601860D RID: 99853 RVA: 0x0038C44F File Offset: 0x0038A64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardActivityInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601860E RID: 99854 RVA: 0x0038C456 File Offset: 0x0038A656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfoResponse()
		{
		}

		// Token: 0x0601860F RID: 99855 RVA: 0x0038C460 File Offset: 0x0038A660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfoResponse(ScratchCardActivityInfoResponse other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018610 RID: 99856 RVA: 0x0038C4AC File Offset: 0x0038A6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfoResponse Clone()
		{
			return new ScratchCardActivityInfoResponse(this);
		}

		// Token: 0x17005229 RID: 21033
		// (get) Token: 0x06018611 RID: 99857 RVA: 0x0038C4B4 File Offset: 0x0038A6B4
		// (set) Token: 0x06018612 RID: 99858 RVA: 0x0038C4BC File Offset: 0x0038A6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x1700522A RID: 21034
		// (get) Token: 0x06018613 RID: 99859 RVA: 0x0038C4C5 File Offset: 0x0038A6C5
		// (set) Token: 0x06018614 RID: 99860 RVA: 0x0038C4CD File Offset: 0x0038A6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x06018615 RID: 99861 RVA: 0x0038C4D6 File Offset: 0x0038A6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardActivityInfoResponse);
		}

		// Token: 0x06018616 RID: 99862 RVA: 0x0038C4E4 File Offset: 0x0038A6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardActivityInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018617 RID: 99863 RVA: 0x0038C534 File Offset: 0x0038A734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018618 RID: 99864 RVA: 0x0038C58F File Offset: 0x0038A78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018619 RID: 99865 RVA: 0x0038C59C File Offset: 0x0038A79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601861A RID: 99866 RVA: 0x0038C5A8 File Offset: 0x0038A7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Error);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601861B RID: 99867 RVA: 0x0038C604 File Offset: 0x0038A804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601861C RID: 99868 RVA: 0x0038C65C File Offset: 0x0038A85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardActivityInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new ScratchCardActivityInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601861D RID: 99869 RVA: 0x0038C6C4 File Offset: 0x0038A8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601861E RID: 99870 RVA: 0x0038C6D0 File Offset: 0x0038A8D0
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
				if (num != 40U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.info_ == null)
						{
							this.Info = new ScratchCardActivityInfo();
						}
						input.ReadMessage(this.Info);
					}
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040090D1 RID: 37073
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090D2 RID: 37074
		public const int InfoFieldNumber = 7;

		// Token: 0x040090D3 RID: 37075
		private ScratchCardActivityInfo info_;

		// Token: 0x040090D4 RID: 37076
		public const int ErrorFieldNumber = 5;

		// Token: 0x040090D5 RID: 37077
		private ErrorCode error_;
	}
}
