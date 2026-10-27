using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200061E RID: 1566
	[NetMessage(EMessageId.ForgeFormulaUnlockResponse)]
	public sealed class ForgeFormulaUnlockResponse : IMessage<ForgeFormulaUnlockResponse>, IMessage, IEquatable<ForgeFormulaUnlockResponse>, IDeepCloneable<ForgeFormulaUnlockResponse>, IBufferMessage
	{
		// Token: 0x06009085 RID: 36997 RVA: 0x0015DD39 File Offset: 0x0015BF39
		[NullableContext(1)]
		public static ForgeFormulaUnlockResponse Create()
		{
			return new ForgeFormulaUnlockResponse();
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06009086 RID: 36998 RVA: 0x0015DD40 File Offset: 0x0015BF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06009087 RID: 36999 RVA: 0x0015DD43 File Offset: 0x0015BF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeFormulaUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06009088 RID: 37000 RVA: 0x0015DD4A File Offset: 0x0015BF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeFormulaUnlockResponse()
		{
		}

		// Token: 0x06009089 RID: 37001 RVA: 0x0015DD52 File Offset: 0x0015BF52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeFormulaUnlockResponse(ForgeFormulaUnlockResponse other) : this()
		{
			this.code_ = other.code_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600908A RID: 37002 RVA: 0x0015DD83 File Offset: 0x0015BF83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeFormulaUnlockResponse Clone()
		{
			return new ForgeFormulaUnlockResponse(this);
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x0600908B RID: 37003 RVA: 0x0015DD8B File Offset: 0x0015BF8B
		// (set) Token: 0x0600908C RID: 37004 RVA: 0x0015DD93 File Offset: 0x0015BF93
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

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x0600908D RID: 37005 RVA: 0x0015DD9C File Offset: 0x0015BF9C
		// (set) Token: 0x0600908E RID: 37006 RVA: 0x0015DDA4 File Offset: 0x0015BFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600908F RID: 37007 RVA: 0x0015DDAD File Offset: 0x0015BFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeFormulaUnlockResponse);
		}

		// Token: 0x06009090 RID: 37008 RVA: 0x0015DDBB File Offset: 0x0015BFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeFormulaUnlockResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009091 RID: 37009 RVA: 0x0015DDFC File Offset: 0x0015BFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009092 RID: 37010 RVA: 0x0015DE5A File Offset: 0x0015C05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009093 RID: 37011 RVA: 0x0015DE67 File Offset: 0x0015C067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009094 RID: 37012 RVA: 0x0015DE70 File Offset: 0x0015C070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009095 RID: 37013 RVA: 0x0015DECC File Offset: 0x0015C0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009096 RID: 37014 RVA: 0x0015DF24 File Offset: 0x0015C124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ForgeFormulaUnlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009097 RID: 37015 RVA: 0x0015DF74 File Offset: 0x0015C174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009098 RID: 37016 RVA: 0x0015DF80 File Offset: 0x0015C180
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040045F3 RID: 17907
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045F4 RID: 17908
		public const int CodeFieldNumber = 15;

		// Token: 0x040045F5 RID: 17909
		private ErrorCode code_;

		// Token: 0x040045F6 RID: 17910
		public const int IdFieldNumber = 3;

		// Token: 0x040045F7 RID: 17911
		private int id_;
	}
}
