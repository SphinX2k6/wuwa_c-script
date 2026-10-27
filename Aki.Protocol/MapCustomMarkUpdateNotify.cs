using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000986 RID: 2438
	[NetMessage(EMessageId.MapCustomMarkUpdateNotify)]
	public sealed class MapCustomMarkUpdateNotify : IMessage<MapCustomMarkUpdateNotify>, IMessage, IEquatable<MapCustomMarkUpdateNotify>, IDeepCloneable<MapCustomMarkUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600D65A RID: 54874 RVA: 0x001F84F0 File Offset: 0x001F66F0
		[NullableContext(1)]
		public static MapCustomMarkUpdateNotify Create()
		{
			return new MapCustomMarkUpdateNotify();
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x0600D65B RID: 54875 RVA: 0x001F84F7 File Offset: 0x001F66F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x0600D65C RID: 54876 RVA: 0x001F84FA File Offset: 0x001F66FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapCustomMarkUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600D65D RID: 54877 RVA: 0x001F8501 File Offset: 0x001F6701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCustomMarkUpdateNotify()
		{
		}

		// Token: 0x0600D65E RID: 54878 RVA: 0x001F8509 File Offset: 0x001F6709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCustomMarkUpdateNotify(MapCustomMarkUpdateNotify other) : this()
		{
			this.markId_ = other.markId_;
			this.isDisable_ = other.isDisable_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D65F RID: 54879 RVA: 0x001F8546 File Offset: 0x001F6746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCustomMarkUpdateNotify Clone()
		{
			return new MapCustomMarkUpdateNotify(this);
		}

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x0600D660 RID: 54880 RVA: 0x001F854E File Offset: 0x001F674E
		// (set) Token: 0x0600D661 RID: 54881 RVA: 0x001F8556 File Offset: 0x001F6756
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

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x0600D662 RID: 54882 RVA: 0x001F855F File Offset: 0x001F675F
		// (set) Token: 0x0600D663 RID: 54883 RVA: 0x001F8567 File Offset: 0x001F6767
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

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x0600D664 RID: 54884 RVA: 0x001F8570 File Offset: 0x001F6770
		// (set) Token: 0x0600D665 RID: 54885 RVA: 0x001F8578 File Offset: 0x001F6778
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

		// Token: 0x0600D666 RID: 54886 RVA: 0x001F8581 File Offset: 0x001F6781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapCustomMarkUpdateNotify);
		}

		// Token: 0x0600D667 RID: 54887 RVA: 0x001F8590 File Offset: 0x001F6790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapCustomMarkUpdateNotify other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && this.IsDisable == other.IsDisable && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D668 RID: 54888 RVA: 0x001F85EC File Offset: 0x001F67EC
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

		// Token: 0x0600D669 RID: 54889 RVA: 0x001F8663 File Offset: 0x001F6863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D66A RID: 54890 RVA: 0x001F8670 File Offset: 0x001F6870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D66B RID: 54891 RVA: 0x001F867C File Offset: 0x001F687C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MarkId);
			}
			if (this.IsDisable)
			{
				output.WriteRawTag(72);
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

		// Token: 0x0600D66C RID: 54892 RVA: 0x001F86F0 File Offset: 0x001F68F0
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

		// Token: 0x0600D66D RID: 54893 RVA: 0x001F8754 File Offset: 0x001F6954
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

		// Token: 0x0600D66E RID: 54894 RVA: 0x001F87B8 File Offset: 0x001F69B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D66F RID: 54895 RVA: 0x001F87C4 File Offset: 0x001F69C4
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
					if (num != 72U)
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

		// Token: 0x04005995 RID: 22933
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005996 RID: 22934
		public const int MarkIdFieldNumber = 1;

		// Token: 0x04005997 RID: 22935
		private int markId_;

		// Token: 0x04005998 RID: 22936
		public const int IsDisableFieldNumber = 9;

		// Token: 0x04005999 RID: 22937
		private bool isDisable_;

		// Token: 0x0400599A RID: 22938
		public const int StateFieldNumber = 13;

		// Token: 0x0400599B RID: 22939
		private MarkState state_;
	}
}
