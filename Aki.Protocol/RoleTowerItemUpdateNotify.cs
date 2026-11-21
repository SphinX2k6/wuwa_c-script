using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010CC RID: 4300
	[NetMessage(EMessageId.RoleTowerItemUpdateNotify)]
	public sealed class RoleTowerItemUpdateNotify : IMessage<RoleTowerItemUpdateNotify>, IMessage, IEquatable<RoleTowerItemUpdateNotify>, IDeepCloneable<RoleTowerItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016FC4 RID: 94148 RVA: 0x00357CCB File Offset: 0x00355ECB
		[NullableContext(1)]
		public static RoleTowerItemUpdateNotify Create()
		{
			return new RoleTowerItemUpdateNotify();
		}

		// Token: 0x17004D1D RID: 19741
		// (get) Token: 0x06016FC5 RID: 94149 RVA: 0x00357CD2 File Offset: 0x00355ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D1E RID: 19742
		// (get) Token: 0x06016FC6 RID: 94150 RVA: 0x00357CD5 File Offset: 0x00355ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016FC7 RID: 94151 RVA: 0x00357CDC File Offset: 0x00355EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerItemUpdateNotify()
		{
		}

		// Token: 0x06016FC8 RID: 94152 RVA: 0x00357CEF File Offset: 0x00355EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerItemUpdateNotify(RoleTowerItemUpdateNotify other) : this()
		{
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016FC9 RID: 94153 RVA: 0x00357D19 File Offset: 0x00355F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerItemUpdateNotify Clone()
		{
			return new RoleTowerItemUpdateNotify(this);
		}

		// Token: 0x17004D1F RID: 19743
		// (get) Token: 0x06016FCA RID: 94154 RVA: 0x00357D21 File Offset: 0x00355F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x06016FCB RID: 94155 RVA: 0x00357D29 File Offset: 0x00355F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerItemUpdateNotify);
		}

		// Token: 0x06016FCC RID: 94156 RVA: 0x00357D37 File Offset: 0x00355F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerItemUpdateNotify other)
		{
			return other != null && (other == this || (this.Items.Equals(other.Items) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016FCD RID: 94157 RVA: 0x00357D6C File Offset: 0x00355F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Items.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016FCE RID: 94158 RVA: 0x00357DA0 File Offset: 0x00355FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016FCF RID: 94159 RVA: 0x00357DAD File Offset: 0x00355FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016FD0 RID: 94160 RVA: 0x00357DB6 File Offset: 0x00355FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, RoleTowerItemUpdateNotify._map_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016FD1 RID: 94161 RVA: 0x00357DE0 File Offset: 0x00355FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.items_.CalculateSize(RoleTowerItemUpdateNotify._map_items_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016FD2 RID: 94162 RVA: 0x00357E19 File Offset: 0x00356019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.items_.MergeFrom(other.items_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016FD3 RID: 94163 RVA: 0x00357E47 File Offset: 0x00356047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016FD4 RID: 94164 RVA: 0x00357E50 File Offset: 0x00356050
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, RoleTowerItemUpdateNotify._map_items_codec);
				}
			}
		}

		// Token: 0x04008993 RID: 35219
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008994 RID: 35220
		public const int ItemsFieldNumber = 2;

		// Token: 0x04008995 RID: 35221
		private static readonly MapField<int, int>.Codec _map_items_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04008996 RID: 35222
		private readonly MapField<int, int> items_ = new MapField<int, int>();
	}
}
