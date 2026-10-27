using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000337 RID: 823
	public sealed class DangoBrawlBagSlotInfo : IMessage<DangoBrawlBagSlotInfo>, IMessage, IEquatable<DangoBrawlBagSlotInfo>, IDeepCloneable<DangoBrawlBagSlotInfo>, IBufferMessage
	{
		// Token: 0x060052A3 RID: 21155 RVA: 0x000C9BA5 File Offset: 0x000C7DA5
		[NullableContext(1)]
		public static DangoBrawlBagSlotInfo Create()
		{
			return new DangoBrawlBagSlotInfo();
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x060052A4 RID: 21156 RVA: 0x000C9BAC File Offset: 0x000C7DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x060052A5 RID: 21157 RVA: 0x000C9BAF File Offset: 0x000C7DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBagSlotInfo.Descriptor;
			}
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x000C9BB6 File Offset: 0x000C7DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagSlotInfo()
		{
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x000C9BBE File Offset: 0x000C7DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagSlotInfo(DangoBrawlBagSlotInfo other) : this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.rotation_ = other.rotation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x000C9BFB File Offset: 0x000C7DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagSlotInfo Clone()
		{
			return new DangoBrawlBagSlotInfo(this);
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x060052A9 RID: 21161 RVA: 0x000C9C03 File Offset: 0x000C7E03
		// (set) Token: 0x060052AA RID: 21162 RVA: 0x000C9C0B File Offset: 0x000C7E0B
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

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x060052AB RID: 21163 RVA: 0x000C9C14 File Offset: 0x000C7E14
		// (set) Token: 0x060052AC RID: 21164 RVA: 0x000C9C1C File Offset: 0x000C7E1C
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

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x060052AD RID: 21165 RVA: 0x000C9C25 File Offset: 0x000C7E25
		// (set) Token: 0x060052AE RID: 21166 RVA: 0x000C9C2D File Offset: 0x000C7E2D
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

		// Token: 0x060052AF RID: 21167 RVA: 0x000C9C36 File Offset: 0x000C7E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBagSlotInfo);
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x000C9C44 File Offset: 0x000C7E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBagSlotInfo other)
		{
			return other != null && (other == this || (this.X == other.X && this.Y == other.Y && this.Rotation == other.Rotation && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x000C9CA0 File Offset: 0x000C7EA0
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

		// Token: 0x060052B2 RID: 21170 RVA: 0x000C9D11 File Offset: 0x000C7F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x000C9D1E File Offset: 0x000C7F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x000C9D28 File Offset: 0x000C7F28
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

		// Token: 0x060052B5 RID: 21173 RVA: 0x000C9D9C File Offset: 0x000C7F9C
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

		// Token: 0x060052B6 RID: 21174 RVA: 0x000C9E0C File Offset: 0x000C800C
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

		// Token: 0x060052B7 RID: 21175 RVA: 0x000C9E70 File Offset: 0x000C8070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x000C9E7C File Offset: 0x000C807C
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

		// Token: 0x04003342 RID: 13122
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003343 RID: 13123
		public const int XFieldNumber = 1;

		// Token: 0x04003344 RID: 13124
		private int x_;

		// Token: 0x04003345 RID: 13125
		public const int YFieldNumber = 2;

		// Token: 0x04003346 RID: 13126
		private int y_;

		// Token: 0x04003347 RID: 13127
		public const int RotationFieldNumber = 3;

		// Token: 0x04003348 RID: 13128
		private int rotation_;
	}
}
