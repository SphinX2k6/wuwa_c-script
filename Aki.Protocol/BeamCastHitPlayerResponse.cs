using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000186 RID: 390
	[NetMessage(EMessageId.BeamCastHitPlayerResponse)]
	public sealed class BeamCastHitPlayerResponse : IMessage<BeamCastHitPlayerResponse>, IMessage, IEquatable<BeamCastHitPlayerResponse>, IDeepCloneable<BeamCastHitPlayerResponse>, IBufferMessage
	{
		// Token: 0x06002F32 RID: 12082 RVA: 0x000795BD File Offset: 0x000777BD
		[NullableContext(1)]
		public static BeamCastHitPlayerResponse Create()
		{
			return new BeamCastHitPlayerResponse();
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x000795C4 File Offset: 0x000777C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06002F34 RID: 12084 RVA: 0x000795C7 File Offset: 0x000777C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeamCastHitPlayerResponse.Descriptor;
			}
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x000795CE File Offset: 0x000777CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerResponse()
		{
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x000795D6 File Offset: 0x000777D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerResponse(BeamCastHitPlayerResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x000795FB File Offset: 0x000777FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerResponse Clone()
		{
			return new BeamCastHitPlayerResponse(this);
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x00079603 File Offset: 0x00077803
		// (set) Token: 0x06002F39 RID: 12089 RVA: 0x0007960B File Offset: 0x0007780B
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

		// Token: 0x06002F3A RID: 12090 RVA: 0x00079614 File Offset: 0x00077814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeamCastHitPlayerResponse);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x00079622 File Offset: 0x00077822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeamCastHitPlayerResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x00079650 File Offset: 0x00077850
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

		// Token: 0x06002F3D RID: 12093 RVA: 0x00079695 File Offset: 0x00077895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000796A2 File Offset: 0x000778A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x000796AB File Offset: 0x000778AB
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

		// Token: 0x06002F40 RID: 12096 RVA: 0x000796E0 File Offset: 0x000778E0
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

		// Token: 0x06002F41 RID: 12097 RVA: 0x0007971E File Offset: 0x0007791E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeamCastHitPlayerResponse other)
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

		// Token: 0x06002F42 RID: 12098 RVA: 0x0007974F File Offset: 0x0007794F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x00079758 File Offset: 0x00077958
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

		// Token: 0x040028F7 RID: 10487
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028F8 RID: 10488
		public const int CodeFieldNumber = 14;

		// Token: 0x040028F9 RID: 10489
		private ErrorCode code_;
	}
}
