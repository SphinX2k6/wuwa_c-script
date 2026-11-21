using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010CE RID: 4302
	public sealed class RoleTowerPhantomAddAttr : IMessage<RoleTowerPhantomAddAttr>, IMessage, IEquatable<RoleTowerPhantomAddAttr>, IDeepCloneable<RoleTowerPhantomAddAttr>, IBufferMessage
	{
		// Token: 0x06016FE9 RID: 94185 RVA: 0x0035813C File Offset: 0x0035633C
		[NullableContext(1)]
		public static RoleTowerPhantomAddAttr Create()
		{
			return new RoleTowerPhantomAddAttr();
		}

		// Token: 0x17004D24 RID: 19748
		// (get) Token: 0x06016FEA RID: 94186 RVA: 0x00358143 File Offset: 0x00356343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerPhantomAddAttr> Parser
		{
			get
			{
				return RoleTowerPhantomAddAttr._parser;
			}
		}

		// Token: 0x17004D25 RID: 19749
		// (get) Token: 0x06016FEB RID: 94187 RVA: 0x0035814A File Offset: 0x0035634A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D26 RID: 19750
		// (get) Token: 0x06016FEC RID: 94188 RVA: 0x0035814D File Offset: 0x0035634D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerPhantomAddAttr.Descriptor;
			}
		}

		// Token: 0x06016FED RID: 94189 RVA: 0x00358154 File Offset: 0x00356354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAddAttr()
		{
		}

		// Token: 0x06016FEE RID: 94190 RVA: 0x00358168 File Offset: 0x00356368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAddAttr(RoleTowerPhantomAddAttr other) : this()
		{
			this.phantomId_ = other.phantomId_;
			this.slotIndex_ = other.slotIndex_;
			this.attrs_ = other.attrs_.Clone();
			this.roleIdOrTrialRoleId_ = other.roleIdOrTrialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016FEF RID: 94191 RVA: 0x003581C1 File Offset: 0x003563C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomAddAttr Clone()
		{
			return new RoleTowerPhantomAddAttr(this);
		}

		// Token: 0x17004D27 RID: 19751
		// (get) Token: 0x06016FF0 RID: 94192 RVA: 0x003581C9 File Offset: 0x003563C9
		// (set) Token: 0x06016FF1 RID: 94193 RVA: 0x003581D1 File Offset: 0x003563D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomId
		{
			get
			{
				return this.phantomId_;
			}
			set
			{
				this.phantomId_ = value;
			}
		}

		// Token: 0x17004D28 RID: 19752
		// (get) Token: 0x06016FF2 RID: 94194 RVA: 0x003581DA File Offset: 0x003563DA
		// (set) Token: 0x06016FF3 RID: 94195 RVA: 0x003581E2 File Offset: 0x003563E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotIndex
		{
			get
			{
				return this.slotIndex_;
			}
			set
			{
				this.slotIndex_ = value;
			}
		}

		// Token: 0x17004D29 RID: 19753
		// (get) Token: 0x06016FF4 RID: 94196 RVA: 0x003581EB File Offset: 0x003563EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Attrs
		{
			get
			{
				return this.attrs_;
			}
		}

		// Token: 0x17004D2A RID: 19754
		// (get) Token: 0x06016FF5 RID: 94197 RVA: 0x003581F3 File Offset: 0x003563F3
		// (set) Token: 0x06016FF6 RID: 94198 RVA: 0x003581FB File Offset: 0x003563FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleIdOrTrialRoleId
		{
			get
			{
				return this.roleIdOrTrialRoleId_;
			}
			set
			{
				this.roleIdOrTrialRoleId_ = value;
			}
		}

		// Token: 0x06016FF7 RID: 94199 RVA: 0x00358204 File Offset: 0x00356404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerPhantomAddAttr);
		}

		// Token: 0x06016FF8 RID: 94200 RVA: 0x00358214 File Offset: 0x00356414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerPhantomAddAttr other)
		{
			return other != null && (other == this || (this.PhantomId == other.PhantomId && this.SlotIndex == other.SlotIndex && this.Attrs.Equals(other.Attrs) && this.RoleIdOrTrialRoleId == other.RoleIdOrTrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016FF9 RID: 94201 RVA: 0x00358284 File Offset: 0x00356484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomId != 0)
			{
				num ^= this.PhantomId.GetHashCode();
			}
			if (this.SlotIndex != 0)
			{
				num ^= this.SlotIndex.GetHashCode();
			}
			num ^= this.Attrs.GetHashCode();
			if (this.RoleIdOrTrialRoleId != 0)
			{
				num ^= this.RoleIdOrTrialRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016FFA RID: 94202 RVA: 0x00358303 File Offset: 0x00356503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016FFB RID: 94203 RVA: 0x00358310 File Offset: 0x00356510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016FFC RID: 94204 RVA: 0x0035831C File Offset: 0x0035651C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomId);
			}
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SlotIndex);
			}
			this.attrs_.WriteTo(ref output, RoleTowerPhantomAddAttr._map_attrs_codec);
			if (this.RoleIdOrTrialRoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleIdOrTrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016FFD RID: 94205 RVA: 0x003583A4 File Offset: 0x003565A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomId);
			}
			if (this.SlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotIndex);
			}
			num += this.attrs_.CalculateSize(RoleTowerPhantomAddAttr._map_attrs_codec);
			if (this.RoleIdOrTrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleIdOrTrialRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016FFE RID: 94206 RVA: 0x00358428 File Offset: 0x00356628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerPhantomAddAttr other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomId != 0)
			{
				this.PhantomId = other.PhantomId;
			}
			if (other.SlotIndex != 0)
			{
				this.SlotIndex = other.SlotIndex;
			}
			this.attrs_.MergeFrom(other.attrs_);
			if (other.RoleIdOrTrialRoleId != 0)
			{
				this.RoleIdOrTrialRoleId = other.RoleIdOrTrialRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016FFF RID: 94207 RVA: 0x0035849D File Offset: 0x0035669D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017000 RID: 94208 RVA: 0x003584A8 File Offset: 0x003566A8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.PhantomId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.SlotIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.attrs_.AddEntriesFrom(ref input, RoleTowerPhantomAddAttr._map_attrs_codec);
						continue;
					}
					if (num == 32U)
					{
						this.RoleIdOrTrialRoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400899E RID: 35230
		private static readonly MessageParser<RoleTowerPhantomAddAttr> _parser = new MessageParser<RoleTowerPhantomAddAttr>(() => new RoleTowerPhantomAddAttr());

		// Token: 0x0400899F RID: 35231
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089A0 RID: 35232
		public const int PhantomIdFieldNumber = 1;

		// Token: 0x040089A1 RID: 35233
		private int phantomId_;

		// Token: 0x040089A2 RID: 35234
		public const int SlotIndexFieldNumber = 2;

		// Token: 0x040089A3 RID: 35235
		private int slotIndex_;

		// Token: 0x040089A4 RID: 35236
		public const int AttrsFieldNumber = 3;

		// Token: 0x040089A5 RID: 35237
		private static readonly MapField<int, int>.Codec _map_attrs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x040089A6 RID: 35238
		private readonly MapField<int, int> attrs_ = new MapField<int, int>();

		// Token: 0x040089A7 RID: 35239
		public const int RoleIdOrTrialRoleIdFieldNumber = 4;

		// Token: 0x040089A8 RID: 35240
		private int roleIdOrTrialRoleId_;
	}
}
