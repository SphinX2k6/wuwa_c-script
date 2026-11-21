using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009BC RID: 2492
	[NetMessage(EMessageId.MaterialReplaceResponse)]
	public sealed class MaterialReplaceResponse : IMessage<MaterialReplaceResponse>, IMessage, IEquatable<MaterialReplaceResponse>, IDeepCloneable<MaterialReplaceResponse>, IBufferMessage
	{
		// Token: 0x0600DB01 RID: 56065 RVA: 0x0020311B File Offset: 0x0020131B
		[NullableContext(1)]
		public static MaterialReplaceResponse Create()
		{
			return new MaterialReplaceResponse();
		}

		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x0600DB02 RID: 56066 RVA: 0x00203122 File Offset: 0x00201322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x0600DB03 RID: 56067 RVA: 0x00203125 File Offset: 0x00201325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialReplaceResponse.Descriptor;
			}
		}

		// Token: 0x0600DB04 RID: 56068 RVA: 0x0020312C File Offset: 0x0020132C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialReplaceResponse()
		{
		}

		// Token: 0x0600DB05 RID: 56069 RVA: 0x00203134 File Offset: 0x00201334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialReplaceResponse(MaterialReplaceResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB06 RID: 56070 RVA: 0x00203159 File Offset: 0x00201359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialReplaceResponse Clone()
		{
			return new MaterialReplaceResponse(this);
		}

		// Token: 0x17002C64 RID: 11364
		// (get) Token: 0x0600DB07 RID: 56071 RVA: 0x00203161 File Offset: 0x00201361
		// (set) Token: 0x0600DB08 RID: 56072 RVA: 0x00203169 File Offset: 0x00201369
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

		// Token: 0x0600DB09 RID: 56073 RVA: 0x00203172 File Offset: 0x00201372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialReplaceResponse);
		}

		// Token: 0x0600DB0A RID: 56074 RVA: 0x00203180 File Offset: 0x00201380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialReplaceResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB0B RID: 56075 RVA: 0x002031B0 File Offset: 0x002013B0
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

		// Token: 0x0600DB0C RID: 56076 RVA: 0x002031F5 File Offset: 0x002013F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB0D RID: 56077 RVA: 0x00203202 File Offset: 0x00201402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB0E RID: 56078 RVA: 0x0020320B File Offset: 0x0020140B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB0F RID: 56079 RVA: 0x00203240 File Offset: 0x00201440
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

		// Token: 0x0600DB10 RID: 56080 RVA: 0x0020327E File Offset: 0x0020147E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MaterialReplaceResponse other)
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

		// Token: 0x0600DB11 RID: 56081 RVA: 0x002032AF File Offset: 0x002014AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB12 RID: 56082 RVA: 0x002032B8 File Offset: 0x002014B8
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B4B RID: 23371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B4C RID: 23372
		public const int CodeFieldNumber = 12;

		// Token: 0x04005B4D RID: 23373
		private ErrorCode code_;
	}
}
