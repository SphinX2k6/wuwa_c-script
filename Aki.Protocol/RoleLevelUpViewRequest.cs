using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001079 RID: 4217
	[NetMessage(EMessageId.RoleLevelUpViewRequest)]
	public sealed class RoleLevelUpViewRequest : IMessage<RoleLevelUpViewRequest>, IMessage, IEquatable<RoleLevelUpViewRequest>, IDeepCloneable<RoleLevelUpViewRequest>, IBufferMessage
	{
		// Token: 0x060168ED RID: 92397 RVA: 0x0034813C File Offset: 0x0034633C
		[NullableContext(1)]
		public static RoleLevelUpViewRequest Create()
		{
			return new RoleLevelUpViewRequest();
		}

		// Token: 0x17004B93 RID: 19347
		// (get) Token: 0x060168EE RID: 92398 RVA: 0x00348143 File Offset: 0x00346343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B94 RID: 19348
		// (get) Token: 0x060168EF RID: 92399 RVA: 0x00348146 File Offset: 0x00346346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleLevelUpViewRequest.Descriptor;
			}
		}

		// Token: 0x060168F0 RID: 92400 RVA: 0x0034814D File Offset: 0x0034634D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLevelUpViewRequest()
		{
		}

		// Token: 0x060168F1 RID: 92401 RVA: 0x00348160 File Offset: 0x00346360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLevelUpViewRequest(RoleLevelUpViewRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.maxItemId_ = other.maxItemId_;
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060168F2 RID: 92402 RVA: 0x003481AD File Offset: 0x003463AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLevelUpViewRequest Clone()
		{
			return new RoleLevelUpViewRequest(this);
		}

		// Token: 0x17004B95 RID: 19349
		// (get) Token: 0x060168F3 RID: 92403 RVA: 0x003481B5 File Offset: 0x003463B5
		// (set) Token: 0x060168F4 RID: 92404 RVA: 0x003481BD File Offset: 0x003463BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004B96 RID: 19350
		// (get) Token: 0x060168F5 RID: 92405 RVA: 0x003481C6 File Offset: 0x003463C6
		// (set) Token: 0x060168F6 RID: 92406 RVA: 0x003481CE File Offset: 0x003463CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxItemId
		{
			get
			{
				return this.maxItemId_;
			}
			set
			{
				this.maxItemId_ = value;
			}
		}

		// Token: 0x17004B97 RID: 19351
		// (get) Token: 0x060168F7 RID: 92407 RVA: 0x003481D7 File Offset: 0x003463D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x060168F8 RID: 92408 RVA: 0x003481DF File Offset: 0x003463DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleLevelUpViewRequest);
		}

		// Token: 0x060168F9 RID: 92409 RVA: 0x003481F0 File Offset: 0x003463F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleLevelUpViewRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.MaxItemId == other.MaxItemId && this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060168FA RID: 92410 RVA: 0x00348250 File Offset: 0x00346450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.MaxItemId != 0)
			{
				num ^= this.MaxItemId.GetHashCode();
			}
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060168FB RID: 92411 RVA: 0x003482B6 File Offset: 0x003464B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060168FC RID: 92412 RVA: 0x003482C3 File Offset: 0x003464C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060168FD RID: 92413 RVA: 0x003482CC File Offset: 0x003464CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this.MaxItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxItemId);
			}
			this.itemList_.WriteTo(ref output, RoleLevelUpViewRequest._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060168FE RID: 92414 RVA: 0x00348338 File Offset: 0x00346538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.MaxItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxItemId);
			}
			num += this.itemList_.CalculateSize(RoleLevelUpViewRequest._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060168FF RID: 92415 RVA: 0x003483A4 File Offset: 0x003465A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleLevelUpViewRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.MaxItemId != 0)
			{
				this.MaxItemId = other.MaxItemId;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016900 RID: 92416 RVA: 0x00348405 File Offset: 0x00346605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016901 RID: 92417 RVA: 0x00348410 File Offset: 0x00346610
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.itemList_.AddEntriesFrom(ref input, RoleLevelUpViewRequest._repeated_itemList_codec);
						}
					}
					else
					{
						this.MaxItemId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008750 RID: 34640
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008751 RID: 34641
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04008752 RID: 34642
		private int roleId_;

		// Token: 0x04008753 RID: 34643
		public const int MaxItemIdFieldNumber = 3;

		// Token: 0x04008754 RID: 34644
		private int maxItemId_;

		// Token: 0x04008755 RID: 34645
		public const int ItemListFieldNumber = 9;

		// Token: 0x04008756 RID: 34646
		private static readonly FieldCodec<ArrayIntInt> _repeated_itemList_codec = FieldCodec.ForMessage<ArrayIntInt>(74U, ArrayIntInt.Parser);

		// Token: 0x04008757 RID: 34647
		private readonly RepeatedField<ArrayIntInt> itemList_ = new RepeatedField<ArrayIntInt>();
	}
}
