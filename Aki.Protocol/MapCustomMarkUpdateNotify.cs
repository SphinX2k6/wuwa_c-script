using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000975 RID: 2421
	[NetMessage(EMessageId.MapCustomMarkUpdateNotify)]
	public sealed class MapCustomMarkUpdateNotify : IMessage<MapCustomMarkUpdateNotify>, IMessage, IEquatable<MapCustomMarkUpdateNotify>, IDeepCloneable<MapCustomMarkUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600D540 RID: 54592 RVA: 0x001F6308 File Offset: 0x001F4508
		[NullableContext(1)]
		public static MapCustomMarkUpdateNotify Create()
		{
			return new MapCustomMarkUpdateNotify();
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x0600D541 RID: 54593 RVA: 0x001F630F File Offset: 0x001F450F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x0600D542 RID: 54594 RVA: 0x001F6312 File Offset: 0x001F4512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapCustomMarkUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600D543 RID: 54595 RVA: 0x001F6319 File Offset: 0x001F4519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCustomMarkUpdateNotify()
		{
		}

		// Token: 0x0600D544 RID: 54596 RVA: 0x001F6321 File Offset: 0x001F4521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCustomMarkUpdateNotify(MapCustomMarkUpdateNotify other) : this()
		{
			this.markId_ = other.markId_;
			this.isDisable_ = other.isDisable_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D545 RID: 54597 RVA: 0x001F635E File Offset: 0x001F455E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCustomMarkUpdateNotify Clone()
		{
			return new MapCustomMarkUpdateNotify(this);
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x0600D546 RID: 54598 RVA: 0x001F6366 File Offset: 0x001F4566
		// (set) Token: 0x0600D547 RID: 54599 RVA: 0x001F636E File Offset: 0x001F456E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x0600D548 RID: 54600 RVA: 0x001F6377 File Offset: 0x001F4577
		// (set) Token: 0x0600D549 RID: 54601 RVA: 0x001F637F File Offset: 0x001F457F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDisable
		{
			get
			{
				return this.isDisable_;
			}
			set
			{
				this.isDisable_ = value;
			}
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x0600D54A RID: 54602 RVA: 0x001F6388 File Offset: 0x001F4588
		// (set) Token: 0x0600D54B RID: 54603 RVA: 0x001F6390 File Offset: 0x001F4590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0600D54C RID: 54604 RVA: 0x001F6399 File Offset: 0x001F4599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapCustomMarkUpdateNotify);
		}

		// Token: 0x0600D54D RID: 54605 RVA: 0x001F63A8 File Offset: 0x001F45A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapCustomMarkUpdateNotify other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && this.IsDisable == other.IsDisable && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D54E RID: 54606 RVA: 0x001F6404 File Offset: 0x001F4604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this.IsDisable)
			{
				num ^= this.IsDisable.GetHashCode();
			}
			if (this.State != MarkState.MarkNormal)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D54F RID: 54607 RVA: 0x001F647B File Offset: 0x001F467B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D550 RID: 54608 RVA: 0x001F6488 File Offset: 0x001F4688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D551 RID: 54609 RVA: 0x001F6494 File Offset: 0x001F4694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.MarkId);
			}
			if (this.IsDisable)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsDisable);
			}
			if (this.State != MarkState.MarkNormal)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D552 RID: 54610 RVA: 0x001F650C File Offset: 0x001F470C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this.IsDisable)
			{
				num += 2;
			}
			if (this.State != MarkState.MarkNormal)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D553 RID: 54611 RVA: 0x001F6570 File Offset: 0x001F4770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapCustomMarkUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			if (other.IsDisable)
			{
				this.IsDisable = other.IsDisable;
			}
			if (other.State != MarkState.MarkNormal)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D554 RID: 54612 RVA: 0x001F65D4 File Offset: 0x001F47D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D555 RID: 54613 RVA: 0x001F65E0 File Offset: 0x001F47E0
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
				if (num != 80U)
				{
					if (num != 96U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.State = (MarkState)input.ReadEnum();
						}
					}
					else
					{
						this.IsDisable = input.ReadBool();
					}
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400599E RID: 22942
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400599F RID: 22943
		public const int MarkIdFieldNumber = 10;

		// Token: 0x040059A0 RID: 22944
		private int markId_;

		// Token: 0x040059A1 RID: 22945
		public const int IsDisableFieldNumber = 12;

		// Token: 0x040059A2 RID: 22946
		private bool isDisable_;

		// Token: 0x040059A3 RID: 22947
		public const int StateFieldNumber = 13;

		// Token: 0x040059A4 RID: 22948
		private MarkState state_;
	}
}
