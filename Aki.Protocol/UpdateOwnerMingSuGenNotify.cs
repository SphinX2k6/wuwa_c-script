using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200149F RID: 5279
	[NetMessage(EMessageId.UpdateOwnerMingSuGenNotify)]
	public sealed class UpdateOwnerMingSuGenNotify : IMessage<UpdateOwnerMingSuGenNotify>, IMessage, IEquatable<UpdateOwnerMingSuGenNotify>, IDeepCloneable<UpdateOwnerMingSuGenNotify>, IBufferMessage
	{
		// Token: 0x0601BEC3 RID: 114371 RVA: 0x00409511 File Offset: 0x00407711
		[NullableContext(1)]
		public static UpdateOwnerMingSuGenNotify Create()
		{
			return new UpdateOwnerMingSuGenNotify();
		}

		// Token: 0x17005E1B RID: 24091
		// (get) Token: 0x0601BEC4 RID: 114372 RVA: 0x00409518 File Offset: 0x00407718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E1C RID: 24092
		// (get) Token: 0x0601BEC5 RID: 114373 RVA: 0x0040951B File Offset: 0x0040771B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateOwnerMingSuGenNotify.Descriptor;
			}
		}

		// Token: 0x0601BEC6 RID: 114374 RVA: 0x00409522 File Offset: 0x00407722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateOwnerMingSuGenNotify()
		{
		}

		// Token: 0x0601BEC7 RID: 114375 RVA: 0x0040952A File Offset: 0x0040772A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateOwnerMingSuGenNotify(UpdateOwnerMingSuGenNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BEC8 RID: 114376 RVA: 0x0040954F File Offset: 0x0040774F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateOwnerMingSuGenNotify Clone()
		{
			return new UpdateOwnerMingSuGenNotify(this);
		}

		// Token: 0x17005E1D RID: 24093
		// (get) Token: 0x0601BEC9 RID: 114377 RVA: 0x00409557 File Offset: 0x00407757
		// (set) Token: 0x0601BECA RID: 114378 RVA: 0x0040955F File Offset: 0x0040775F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x0601BECB RID: 114379 RVA: 0x00409568 File Offset: 0x00407768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateOwnerMingSuGenNotify);
		}

		// Token: 0x0601BECC RID: 114380 RVA: 0x00409576 File Offset: 0x00407776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateOwnerMingSuGenNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BECD RID: 114381 RVA: 0x004095A4 File Offset: 0x004077A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BECE RID: 114382 RVA: 0x004095E3 File Offset: 0x004077E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BECF RID: 114383 RVA: 0x004095F0 File Offset: 0x004077F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BED0 RID: 114384 RVA: 0x004095F9 File Offset: 0x004077F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BED1 RID: 114385 RVA: 0x0040962C File Offset: 0x0040782C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BED2 RID: 114386 RVA: 0x0040966A File Offset: 0x0040786A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateOwnerMingSuGenNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BED3 RID: 114387 RVA: 0x0040969B File Offset: 0x0040789B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BED4 RID: 114388 RVA: 0x004096A4 File Offset: 0x004078A4
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A078 RID: 41080
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A079 RID: 41081
		public const int IdFieldNumber = 7;

		// Token: 0x0400A07A RID: 41082
		private long id_;
	}
}
