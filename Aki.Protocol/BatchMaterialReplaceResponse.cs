using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200015E RID: 350
	[NetMessage(EMessageId.BatchMaterialReplaceResponse)]
	public sealed class BatchMaterialReplaceResponse : IMessage<BatchMaterialReplaceResponse>, IMessage, IEquatable<BatchMaterialReplaceResponse>, IDeepCloneable<BatchMaterialReplaceResponse>, IBufferMessage
	{
		// Token: 0x06002BF4 RID: 11252 RVA: 0x00072A61 File Offset: 0x00070C61
		[NullableContext(1)]
		public static BatchMaterialReplaceResponse Create()
		{
			return new BatchMaterialReplaceResponse();
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x00072A68 File Offset: 0x00070C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x00072A6B File Offset: 0x00070C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchMaterialReplaceResponse.Descriptor;
			}
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x00072A72 File Offset: 0x00070C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMaterialReplaceResponse()
		{
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00072A7A File Offset: 0x00070C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMaterialReplaceResponse(BatchMaterialReplaceResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x00072A9F File Offset: 0x00070C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMaterialReplaceResponse Clone()
		{
			return new BatchMaterialReplaceResponse(this);
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x00072AA7 File Offset: 0x00070CA7
		// (set) Token: 0x06002BFB RID: 11259 RVA: 0x00072AAF File Offset: 0x00070CAF
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

		// Token: 0x06002BFC RID: 11260 RVA: 0x00072AB8 File Offset: 0x00070CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchMaterialReplaceResponse);
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x00072AC6 File Offset: 0x00070CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchMaterialReplaceResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x00072AF4 File Offset: 0x00070CF4
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

		// Token: 0x06002BFF RID: 11263 RVA: 0x00072B39 File Offset: 0x00070D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x00072B46 File Offset: 0x00070D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x00072B4F File Offset: 0x00070D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x00072B84 File Offset: 0x00070D84
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

		// Token: 0x06002C03 RID: 11267 RVA: 0x00072BC2 File Offset: 0x00070DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchMaterialReplaceResponse other)
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

		// Token: 0x06002C04 RID: 11268 RVA: 0x00072BF3 File Offset: 0x00070DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00072BFC File Offset: 0x00070DFC
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040027D9 RID: 10201
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027DA RID: 10202
		public const int CodeFieldNumber = 6;

		// Token: 0x040027DB RID: 10203
		private ErrorCode code_;
	}
}
