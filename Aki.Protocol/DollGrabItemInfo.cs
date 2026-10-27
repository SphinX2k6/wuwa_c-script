using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003EE RID: 1006
	public sealed class DollGrabItemInfo : IMessage<DollGrabItemInfo>, IMessage, IEquatable<DollGrabItemInfo>, IDeepCloneable<DollGrabItemInfo>, IBufferMessage
	{
		// Token: 0x06006183 RID: 24963 RVA: 0x000EB3CD File Offset: 0x000E95CD
		[NullableContext(1)]
		public static DollGrabItemInfo Create()
		{
			return new DollGrabItemInfo();
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06006184 RID: 24964 RVA: 0x000EB3D4 File Offset: 0x000E95D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DollGrabItemInfo> Parser
		{
			get
			{
				return DollGrabItemInfo._parser;
			}
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06006185 RID: 24965 RVA: 0x000EB3DB File Offset: 0x000E95DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06006186 RID: 24966 RVA: 0x000EB3DE File Offset: 0x000E95DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabItemInfo.Descriptor;
			}
		}

		// Token: 0x06006187 RID: 24967 RVA: 0x000EB3E5 File Offset: 0x000E95E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabItemInfo()
		{
		}

		// Token: 0x06006188 RID: 24968 RVA: 0x000EB3ED File Offset: 0x000E95ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabItemInfo(DollGrabItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x000EB41E File Offset: 0x000E961E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabItemInfo Clone()
		{
			return new DollGrabItemInfo(this);
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x0600618A RID: 24970 RVA: 0x000EB426 File Offset: 0x000E9626
		// (set) Token: 0x0600618B RID: 24971 RVA: 0x000EB42E File Offset: 0x000E962E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x0600618C RID: 24972 RVA: 0x000EB437 File Offset: 0x000E9637
		// (set) Token: 0x0600618D RID: 24973 RVA: 0x000EB43F File Offset: 0x000E963F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x000EB448 File Offset: 0x000E9648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabItemInfo);
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x000EB456 File Offset: 0x000E9656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x000EB494 File Offset: 0x000E9694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x000EB4EC File Offset: 0x000E96EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x000EB4F9 File Offset: 0x000E96F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x000EB504 File Offset: 0x000E9704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x000EB55C File Offset: 0x000E975C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x000EB5B4 File Offset: 0x000E97B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x000EB604 File Offset: 0x000E9804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x000EB610 File Offset: 0x000E9810
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemCount = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040037A0 RID: 14240
		private static readonly MessageParser<DollGrabItemInfo> _parser = new MessageParser<DollGrabItemInfo>(() => new DollGrabItemInfo());

		// Token: 0x040037A1 RID: 14241
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037A2 RID: 14242
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040037A3 RID: 14243
		private int itemId_;

		// Token: 0x040037A4 RID: 14244
		public const int ItemCountFieldNumber = 2;

		// Token: 0x040037A5 RID: 14245
		private int itemCount_;
	}
}
