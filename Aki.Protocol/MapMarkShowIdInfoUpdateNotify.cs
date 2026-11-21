using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200097D RID: 2429
	[NetMessage(EMessageId.MapMarkShowIdInfoUpdateNotify)]
	public sealed class MapMarkShowIdInfoUpdateNotify : IMessage<MapMarkShowIdInfoUpdateNotify>, IMessage, IEquatable<MapMarkShowIdInfoUpdateNotify>, IDeepCloneable<MapMarkShowIdInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600D5E4 RID: 54756 RVA: 0x001F7CAB File Offset: 0x001F5EAB
		[NullableContext(1)]
		public static MapMarkShowIdInfoUpdateNotify Create()
		{
			return new MapMarkShowIdInfoUpdateNotify();
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x0600D5E5 RID: 54757 RVA: 0x001F7CB2 File Offset: 0x001F5EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x0600D5E6 RID: 54758 RVA: 0x001F7CB5 File Offset: 0x001F5EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkShowIdInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600D5E7 RID: 54759 RVA: 0x001F7CBC File Offset: 0x001F5EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowIdInfoUpdateNotify()
		{
		}

		// Token: 0x0600D5E8 RID: 54760 RVA: 0x001F7CC4 File Offset: 0x001F5EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowIdInfoUpdateNotify(MapMarkShowIdInfoUpdateNotify other) : this()
		{
			this.markId_ = other.markId_;
			this.isShow_ = other.isShow_;
			this.needFocus_ = other.needFocus_;
			this.showFlag_ = other.showFlag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5E9 RID: 54761 RVA: 0x001F7D18 File Offset: 0x001F5F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowIdInfoUpdateNotify Clone()
		{
			return new MapMarkShowIdInfoUpdateNotify(this);
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x0600D5EA RID: 54762 RVA: 0x001F7D20 File Offset: 0x001F5F20
		// (set) Token: 0x0600D5EB RID: 54763 RVA: 0x001F7D28 File Offset: 0x001F5F28
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

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x0600D5EC RID: 54764 RVA: 0x001F7D31 File Offset: 0x001F5F31
		// (set) Token: 0x0600D5ED RID: 54765 RVA: 0x001F7D39 File Offset: 0x001F5F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x0600D5EE RID: 54766 RVA: 0x001F7D42 File Offset: 0x001F5F42
		// (set) Token: 0x0600D5EF RID: 54767 RVA: 0x001F7D4A File Offset: 0x001F5F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedFocus
		{
			get
			{
				return this.needFocus_;
			}
			set
			{
				this.needFocus_ = value;
			}
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x0600D5F0 RID: 54768 RVA: 0x001F7D53 File Offset: 0x001F5F53
		// (set) Token: 0x0600D5F1 RID: 54769 RVA: 0x001F7D5B File Offset: 0x001F5F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ShowFlag
		{
			get
			{
				return this.showFlag_;
			}
			set
			{
				this.showFlag_ = value;
			}
		}

		// Token: 0x0600D5F2 RID: 54770 RVA: 0x001F7D64 File Offset: 0x001F5F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkShowIdInfoUpdateNotify);
		}

		// Token: 0x0600D5F3 RID: 54771 RVA: 0x001F7D74 File Offset: 0x001F5F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkShowIdInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && this.IsShow == other.IsShow && this.NeedFocus == other.NeedFocus && this.ShowFlag == other.ShowFlag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D5F4 RID: 54772 RVA: 0x001F7DE0 File Offset: 0x001F5FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this.NeedFocus)
			{
				num ^= this.NeedFocus.GetHashCode();
			}
			if (this.ShowFlag != 0U)
			{
				num ^= this.ShowFlag.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D5F5 RID: 54773 RVA: 0x001F7E6A File Offset: 0x001F606A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D5F6 RID: 54774 RVA: 0x001F7E77 File Offset: 0x001F6077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5F7 RID: 54775 RVA: 0x001F7E80 File Offset: 0x001F6080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowFlag != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ShowFlag);
			}
			if (this.IsShow)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsShow);
			}
			if (this.MarkId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MarkId);
			}
			if (this.NeedFocus)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.NeedFocus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D5F8 RID: 54776 RVA: 0x001F7F10 File Offset: 0x001F6110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this.IsShow)
			{
				num += 2;
			}
			if (this.NeedFocus)
			{
				num += 2;
			}
			if (this.ShowFlag != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShowFlag);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D5F9 RID: 54777 RVA: 0x001F7F80 File Offset: 0x001F6180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapMarkShowIdInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			if (other.NeedFocus)
			{
				this.NeedFocus = other.NeedFocus;
			}
			if (other.ShowFlag != 0U)
			{
				this.ShowFlag = other.ShowFlag;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D5FA RID: 54778 RVA: 0x001F7FF8 File Offset: 0x001F61F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5FB RID: 54779 RVA: 0x001F8004 File Offset: 0x001F6204
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.ShowFlag = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.IsShow = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.MarkId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.NeedFocus = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040059D6 RID: 22998
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059D7 RID: 22999
		public const int MarkIdFieldNumber = 5;

		// Token: 0x040059D8 RID: 23000
		private int markId_;

		// Token: 0x040059D9 RID: 23001
		public const int IsShowFieldNumber = 3;

		// Token: 0x040059DA RID: 23002
		private bool isShow_;

		// Token: 0x040059DB RID: 23003
		public const int NeedFocusFieldNumber = 11;

		// Token: 0x040059DC RID: 23004
		private bool needFocus_;

		// Token: 0x040059DD RID: 23005
		public const int ShowFlagFieldNumber = 1;

		// Token: 0x040059DE RID: 23006
		private uint showFlag_;
	}
}
