using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D8 RID: 4312
	[NetMessage(EMessageId.RollBlockExitGamePlayResponse)]
	public sealed class RollBlockExitGamePlayResponse : IMessage<RollBlockExitGamePlayResponse>, IMessage, IEquatable<RollBlockExitGamePlayResponse>, IDeepCloneable<RollBlockExitGamePlayResponse>, IBufferMessage
	{
		// Token: 0x0601700A RID: 94218 RVA: 0x003568C9 File Offset: 0x00354AC9
		[NullableContext(1)]
		public static RollBlockExitGamePlayResponse Create()
		{
			return new RollBlockExitGamePlayResponse();
		}

		// Token: 0x17004D0A RID: 19722
		// (get) Token: 0x0601700B RID: 94219 RVA: 0x003568D0 File Offset: 0x00354AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D0B RID: 19723
		// (get) Token: 0x0601700C RID: 94220 RVA: 0x003568D3 File Offset: 0x00354AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockExitGamePlayResponse.Descriptor;
			}
		}

		// Token: 0x0601700D RID: 94221 RVA: 0x003568DA File Offset: 0x00354ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockExitGamePlayResponse()
		{
		}

		// Token: 0x0601700E RID: 94222 RVA: 0x003568E2 File Offset: 0x00354AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockExitGamePlayResponse(RollBlockExitGamePlayResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601700F RID: 94223 RVA: 0x00356907 File Offset: 0x00354B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockExitGamePlayResponse Clone()
		{
			return new RollBlockExitGamePlayResponse(this);
		}

		// Token: 0x17004D0C RID: 19724
		// (get) Token: 0x06017010 RID: 94224 RVA: 0x0035690F File Offset: 0x00354B0F
		// (set) Token: 0x06017011 RID: 94225 RVA: 0x00356917 File Offset: 0x00354B17
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

		// Token: 0x06017012 RID: 94226 RVA: 0x00356920 File Offset: 0x00354B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockExitGamePlayResponse);
		}

		// Token: 0x06017013 RID: 94227 RVA: 0x0035692E File Offset: 0x00354B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockExitGamePlayResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017014 RID: 94228 RVA: 0x0035695C File Offset: 0x00354B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017015 RID: 94229 RVA: 0x003569A1 File Offset: 0x00354BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017016 RID: 94230 RVA: 0x003569AE File Offset: 0x00354BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017017 RID: 94231 RVA: 0x003569B7 File Offset: 0x00354BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017018 RID: 94232 RVA: 0x003569EC File Offset: 0x00354BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017019 RID: 94233 RVA: 0x00356A2A File Offset: 0x00354C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockExitGamePlayResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601701A RID: 94234 RVA: 0x00356A5B File Offset: 0x00354C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601701B RID: 94235 RVA: 0x00356A64 File Offset: 0x00354C64
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040088EE RID: 35054
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088EF RID: 35055
		public const int CodeFieldNumber = 14;

		// Token: 0x040088F0 RID: 35056
		private ErrorCode code_;
	}
}
