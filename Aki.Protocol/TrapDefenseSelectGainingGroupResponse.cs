using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B8 RID: 5304
	[NetMessage(EMessageId.TrapDefenseSelectGainingGroupResponse)]
	public sealed class TrapDefenseSelectGainingGroupResponse : IMessage<TrapDefenseSelectGainingGroupResponse>, IMessage, IEquatable<TrapDefenseSelectGainingGroupResponse>, IDeepCloneable<TrapDefenseSelectGainingGroupResponse>, IBufferMessage
	{
		// Token: 0x0601C245 RID: 115269 RVA: 0x00415C85 File Offset: 0x00413E85
		[NullableContext(1)]
		public static TrapDefenseSelectGainingGroupResponse Create()
		{
			return new TrapDefenseSelectGainingGroupResponse();
		}

		// Token: 0x17005F40 RID: 24384
		// (get) Token: 0x0601C246 RID: 115270 RVA: 0x00415C8C File Offset: 0x00413E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F41 RID: 24385
		// (get) Token: 0x0601C247 RID: 115271 RVA: 0x00415C8F File Offset: 0x00413E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSelectGainingGroupResponse.Descriptor;
			}
		}

		// Token: 0x0601C248 RID: 115272 RVA: 0x00415C96 File Offset: 0x00413E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSelectGainingGroupResponse()
		{
		}

		// Token: 0x0601C249 RID: 115273 RVA: 0x00415C9E File Offset: 0x00413E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSelectGainingGroupResponse(TrapDefenseSelectGainingGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C24A RID: 115274 RVA: 0x00415CC3 File Offset: 0x00413EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSelectGainingGroupResponse Clone()
		{
			return new TrapDefenseSelectGainingGroupResponse(this);
		}

		// Token: 0x17005F42 RID: 24386
		// (get) Token: 0x0601C24B RID: 115275 RVA: 0x00415CCB File Offset: 0x00413ECB
		// (set) Token: 0x0601C24C RID: 115276 RVA: 0x00415CD3 File Offset: 0x00413ED3
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

		// Token: 0x0601C24D RID: 115277 RVA: 0x00415CDC File Offset: 0x00413EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSelectGainingGroupResponse);
		}

		// Token: 0x0601C24E RID: 115278 RVA: 0x00415CEA File Offset: 0x00413EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSelectGainingGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C24F RID: 115279 RVA: 0x00415D18 File Offset: 0x00413F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601C250 RID: 115280 RVA: 0x00415D5D File Offset: 0x00413F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C251 RID: 115281 RVA: 0x00415D6A File Offset: 0x00413F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C252 RID: 115282 RVA: 0x00415D73 File Offset: 0x00413F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C253 RID: 115283 RVA: 0x00415DA8 File Offset: 0x00413FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601C254 RID: 115284 RVA: 0x00415DE6 File Offset: 0x00413FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSelectGainingGroupResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C255 RID: 115285 RVA: 0x00415E17 File Offset: 0x00414017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C256 RID: 115286 RVA: 0x00415E20 File Offset: 0x00414020
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A2D4 RID: 41684
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2D5 RID: 41685
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400A2D6 RID: 41686
		private ErrorCode errorCode_;
	}
}
