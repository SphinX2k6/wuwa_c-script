using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200124A RID: 4682
	[NetMessage(EMessageId.ShortMessageUpdateRequest)]
	public sealed class ShortMessageUpdateRequest : IMessage<ShortMessageUpdateRequest>, IMessage, IEquatable<ShortMessageUpdateRequest>, IDeepCloneable<ShortMessageUpdateRequest>, IBufferMessage
	{
		// Token: 0x06019000 RID: 102400 RVA: 0x003A4FF7 File Offset: 0x003A31F7
		[NullableContext(1)]
		public static ShortMessageUpdateRequest Create()
		{
			return new ShortMessageUpdateRequest();
		}

		// Token: 0x1700547C RID: 21628
		// (get) Token: 0x06019001 RID: 102401 RVA: 0x003A4FFE File Offset: 0x003A31FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700547D RID: 21629
		// (get) Token: 0x06019002 RID: 102402 RVA: 0x003A5001 File Offset: 0x003A3201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06019003 RID: 102403 RVA: 0x003A5008 File Offset: 0x003A3208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateRequest()
		{
		}

		// Token: 0x06019004 RID: 102404 RVA: 0x003A5010 File Offset: 0x003A3210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateRequest(ShortMessageUpdateRequest other) : this()
		{
			this.configId_ = other.configId_;
			this.lastConfigId_ = other.lastConfigId_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019005 RID: 102405 RVA: 0x003A504D File Offset: 0x003A324D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateRequest Clone()
		{
			return new ShortMessageUpdateRequest(this);
		}

		// Token: 0x1700547E RID: 21630
		// (get) Token: 0x06019006 RID: 102406 RVA: 0x003A5055 File Offset: 0x003A3255
		// (set) Token: 0x06019007 RID: 102407 RVA: 0x003A505D File Offset: 0x003A325D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x1700547F RID: 21631
		// (get) Token: 0x06019008 RID: 102408 RVA: 0x003A5066 File Offset: 0x003A3266
		// (set) Token: 0x06019009 RID: 102409 RVA: 0x003A506E File Offset: 0x003A326E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastConfigId
		{
			get
			{
				return this.lastConfigId_;
			}
			set
			{
				this.lastConfigId_ = value;
			}
		}

		// Token: 0x17005480 RID: 21632
		// (get) Token: 0x0601900A RID: 102410 RVA: 0x003A5077 File Offset: 0x003A3277
		// (set) Token: 0x0601900B RID: 102411 RVA: 0x003A507F File Offset: 0x003A327F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x0601900C RID: 102412 RVA: 0x003A5088 File Offset: 0x003A3288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageUpdateRequest);
		}

		// Token: 0x0601900D RID: 102413 RVA: 0x003A5098 File Offset: 0x003A3298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageUpdateRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.LastConfigId == other.LastConfigId && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601900E RID: 102414 RVA: 0x003A50F4 File Offset: 0x003A32F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.LastConfigId != 0)
			{
				num ^= this.LastConfigId.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601900F RID: 102415 RVA: 0x003A5165 File Offset: 0x003A3365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019010 RID: 102416 RVA: 0x003A5172 File Offset: 0x003A3372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019011 RID: 102417 RVA: 0x003A517C File Offset: 0x003A337C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ConfigId);
			}
			if (this.LastConfigId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LastConfigId);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019012 RID: 102418 RVA: 0x003A51F4 File Offset: 0x003A33F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.LastConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastConfigId);
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019013 RID: 102419 RVA: 0x003A5258 File Offset: 0x003A3458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.LastConfigId != 0)
			{
				this.LastConfigId = other.LastConfigId;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019014 RID: 102420 RVA: 0x003A52BC File Offset: 0x003A34BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019015 RID: 102421 RVA: 0x003A52C8 File Offset: 0x003A34C8
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
				if (num != 64U)
				{
					if (num != 72U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsFinish = input.ReadBool();
						}
					}
					else
					{
						this.LastConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400943D RID: 37949
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400943E RID: 37950
		public const int ConfigIdFieldNumber = 8;

		// Token: 0x0400943F RID: 37951
		private int configId_;

		// Token: 0x04009440 RID: 37952
		public const int LastConfigIdFieldNumber = 9;

		// Token: 0x04009441 RID: 37953
		private int lastConfigId_;

		// Token: 0x04009442 RID: 37954
		public const int IsFinishFieldNumber = 15;

		// Token: 0x04009443 RID: 37955
		private bool isFinish_;
	}
}
