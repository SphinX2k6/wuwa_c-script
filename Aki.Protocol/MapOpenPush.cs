using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200097F RID: 2431
	[NetMessage(EMessageId.MapOpenPush)]
	public sealed class MapOpenPush : IMessage<MapOpenPush>, IMessage, IEquatable<MapOpenPush>, IDeepCloneable<MapOpenPush>, IBufferMessage
	{
		// Token: 0x0600D612 RID: 54802 RVA: 0x001F833F File Offset: 0x001F653F
		[NullableContext(1)]
		public static MapOpenPush Create()
		{
			return new MapOpenPush();
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x0600D613 RID: 54803 RVA: 0x001F8346 File Offset: 0x001F6546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x0600D614 RID: 54804 RVA: 0x001F8349 File Offset: 0x001F6549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapOpenPush.Descriptor;
			}
		}

		// Token: 0x0600D615 RID: 54805 RVA: 0x001F8350 File Offset: 0x001F6550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapOpenPush()
		{
		}

		// Token: 0x0600D616 RID: 54806 RVA: 0x001F8358 File Offset: 0x001F6558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapOpenPush(MapOpenPush other) : this()
		{
			this.openType_ = other.openType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D617 RID: 54807 RVA: 0x001F837D File Offset: 0x001F657D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapOpenPush Clone()
		{
			return new MapOpenPush(this);
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x0600D618 RID: 54808 RVA: 0x001F8385 File Offset: 0x001F6585
		// (set) Token: 0x0600D619 RID: 54809 RVA: 0x001F838D File Offset: 0x001F658D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapOpenType OpenType
		{
			get
			{
				return this.openType_;
			}
			set
			{
				this.openType_ = value;
			}
		}

		// Token: 0x0600D61A RID: 54810 RVA: 0x001F8396 File Offset: 0x001F6596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapOpenPush);
		}

		// Token: 0x0600D61B RID: 54811 RVA: 0x001F83A4 File Offset: 0x001F65A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapOpenPush other)
		{
			return other != null && (other == this || (this.OpenType == other.OpenType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D61C RID: 54812 RVA: 0x001F83D4 File Offset: 0x001F65D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OpenType != MapOpenType.HotKey)
			{
				num ^= this.OpenType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D61D RID: 54813 RVA: 0x001F8419 File Offset: 0x001F6619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D61E RID: 54814 RVA: 0x001F8426 File Offset: 0x001F6626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D61F RID: 54815 RVA: 0x001F842F File Offset: 0x001F662F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpenType != MapOpenType.HotKey)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.OpenType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D620 RID: 54816 RVA: 0x001F8464 File Offset: 0x001F6664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OpenType != MapOpenType.HotKey)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OpenType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D621 RID: 54817 RVA: 0x001F84A2 File Offset: 0x001F66A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapOpenPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OpenType != MapOpenType.HotKey)
			{
				this.OpenType = other.OpenType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D622 RID: 54818 RVA: 0x001F84D3 File Offset: 0x001F66D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D623 RID: 54819 RVA: 0x001F84DC File Offset: 0x001F66DC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.OpenType = (MapOpenType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040059E5 RID: 23013
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059E6 RID: 23014
		public const int OpenTypeFieldNumber = 13;

		// Token: 0x040059E7 RID: 23015
		private MapOpenType openType_;
	}
}
