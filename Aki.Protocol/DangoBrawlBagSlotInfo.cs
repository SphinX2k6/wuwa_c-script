using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200033F RID: 831
	public sealed class DangoBrawlBagSlotInfo : IMessage<DangoBrawlBagSlotInfo>, IMessage, IEquatable<DangoBrawlBagSlotInfo>, IDeepCloneable<DangoBrawlBagSlotInfo>, IBufferMessage
	{
		// Token: 0x06005390 RID: 21392 RVA: 0x000CC229 File Offset: 0x000CA429
		[NullableContext(1)]
		public static DangoBrawlBagSlotInfo Create()
		{
			return new DangoBrawlBagSlotInfo();
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06005391 RID: 21393 RVA: 0x000CC230 File Offset: 0x000CA430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06005392 RID: 21394 RVA: 0x000CC233 File Offset: 0x000CA433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBagSlotInfo.Descriptor;
			}
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x000CC23A File Offset: 0x000CA43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagSlotInfo()
		{
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x000CC242 File Offset: 0x000CA442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagSlotInfo(DangoBrawlBagSlotInfo other) : this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.rotation_ = other.rotation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x000CC27F File Offset: 0x000CA47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagSlotInfo Clone()
		{
			return new DangoBrawlBagSlotInfo(this);
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06005396 RID: 21398 RVA: 0x000CC287 File Offset: 0x000CA487
		// (set) Token: 0x06005397 RID: 21399 RVA: 0x000CC28F File Offset: 0x000CA48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06005398 RID: 21400 RVA: 0x000CC298 File Offset: 0x000CA498
		// (set) Token: 0x06005399 RID: 21401 RVA: 0x000CC2A0 File Offset: 0x000CA4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x0600539A RID: 21402 RVA: 0x000CC2A9 File Offset: 0x000CA4A9
		// (set) Token: 0x0600539B RID: 21403 RVA: 0x000CC2B1 File Offset: 0x000CA4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x000CC2BA File Offset: 0x000CA4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBagSlotInfo);
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x000CC2C8 File Offset: 0x000CA4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBagSlotInfo other)
		{
			return other != null && (other == this || (this.X == other.X && this.Y == other.Y && this.Rotation == other.Rotation && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x000CC324 File Offset: 0x000CA524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.X != 0)
			{
				num ^= this.X.GetHashCode();
			}
			if (this.Y != 0)
			{
				num ^= this.Y.GetHashCode();
			}
			if (this.Rotation != 0)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x000CC395 File Offset: 0x000CA595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x000CC3A2 File Offset: 0x000CA5A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x000CC3AC File Offset: 0x000CA5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.X != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.X);
			}
			if (this.Y != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Y);
			}
			if (this.Rotation != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x000CC420 File Offset: 0x000CA620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.X != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.X);
			}
			if (this.Y != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Y);
			}
			if (this.Rotation != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x000CC490 File Offset: 0x000CA690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlBagSlotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.X != 0)
			{
				this.X = other.X;
			}
			if (other.Y != 0)
			{
				this.Y = other.Y;
			}
			if (other.Rotation != 0)
			{
				this.Rotation = other.Rotation;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x000CC4F4 File Offset: 0x000CA6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x000CC500 File Offset: 0x000CA700
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Rotation = input.ReadInt32();
						}
					}
					else
					{
						this.Y = input.ReadInt32();
					}
				}
				else
				{
					this.X = input.ReadInt32();
				}
			}
		}

		// Token: 0x040033DE RID: 13278
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033DF RID: 13279
		public const int XFieldNumber = 1;

		// Token: 0x040033E0 RID: 13280
		private int x_;

		// Token: 0x040033E1 RID: 13281
		public const int YFieldNumber = 2;

		// Token: 0x040033E2 RID: 13282
		private int y_;

		// Token: 0x040033E3 RID: 13283
		public const int RotationFieldNumber = 3;

		// Token: 0x040033E4 RID: 13284
		private int rotation_;
	}
}
