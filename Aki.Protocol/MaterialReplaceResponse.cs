using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009CD RID: 2509
	[NetMessage(EMessageId.MaterialReplaceResponse)]
	public sealed class MaterialReplaceResponse : IMessage<MaterialReplaceResponse>, IMessage, IEquatable<MaterialReplaceResponse>, IDeepCloneable<MaterialReplaceResponse>, IBufferMessage
	{
		// Token: 0x0600DC1B RID: 56347 RVA: 0x00205313 File Offset: 0x00203513
		[NullableContext(1)]
		public static MaterialReplaceResponse Create()
		{
			return new MaterialReplaceResponse();
		}

		// Token: 0x17002CA0 RID: 11424
		// (get) Token: 0x0600DC1C RID: 56348 RVA: 0x0020531A File Offset: 0x0020351A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CA1 RID: 11425
		// (get) Token: 0x0600DC1D RID: 56349 RVA: 0x0020531D File Offset: 0x0020351D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialReplaceResponse.Descriptor;
			}
		}

		// Token: 0x0600DC1E RID: 56350 RVA: 0x00205324 File Offset: 0x00203524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialReplaceResponse()
		{
		}

		// Token: 0x0600DC1F RID: 56351 RVA: 0x0020532C File Offset: 0x0020352C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialReplaceResponse(MaterialReplaceResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC20 RID: 56352 RVA: 0x00205351 File Offset: 0x00203551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialReplaceResponse Clone()
		{
			return new MaterialReplaceResponse(this);
		}

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x0600DC21 RID: 56353 RVA: 0x00205359 File Offset: 0x00203559
		// (set) Token: 0x0600DC22 RID: 56354 RVA: 0x00205361 File Offset: 0x00203561
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

		// Token: 0x0600DC23 RID: 56355 RVA: 0x0020536A File Offset: 0x0020356A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialReplaceResponse);
		}

		// Token: 0x0600DC24 RID: 56356 RVA: 0x00205378 File Offset: 0x00203578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialReplaceResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC25 RID: 56357 RVA: 0x002053A8 File Offset: 0x002035A8
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

		// Token: 0x0600DC26 RID: 56358 RVA: 0x002053ED File Offset: 0x002035ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC27 RID: 56359 RVA: 0x002053FA File Offset: 0x002035FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC28 RID: 56360 RVA: 0x00205403 File Offset: 0x00203603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC29 RID: 56361 RVA: 0x00205438 File Offset: 0x00203638
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

		// Token: 0x0600DC2A RID: 56362 RVA: 0x00205476 File Offset: 0x00203676
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

		// Token: 0x0600DC2B RID: 56363 RVA: 0x002054A7 File Offset: 0x002036A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC2C RID: 56364 RVA: 0x002054B0 File Offset: 0x002036B0
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B42 RID: 23362
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B43 RID: 23363
		public const int CodeFieldNumber = 4;

		// Token: 0x04005B44 RID: 23364
		private ErrorCode code_;
	}
}
