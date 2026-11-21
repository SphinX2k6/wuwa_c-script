using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000478 RID: 1144
	[NetMessage(EMessageId.EntityFoundationCoreChangeNotify)]
	public sealed class EntityFoundationCoreChangeNotify : IMessage<EntityFoundationCoreChangeNotify>, IMessage, IEquatable<EntityFoundationCoreChangeNotify>, IDeepCloneable<EntityFoundationCoreChangeNotify>, IBufferMessage
	{
		// Token: 0x06006E05 RID: 28165 RVA: 0x0010ECEC File Offset: 0x0010CEEC
		[NullableContext(1)]
		public static EntityFoundationCoreChangeNotify Create()
		{
			return new EntityFoundationCoreChangeNotify();
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06006E06 RID: 28166 RVA: 0x0010ECF3 File Offset: 0x0010CEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06006E07 RID: 28167 RVA: 0x0010ECF6 File Offset: 0x0010CEF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityFoundationCoreChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x0010ECFD File Offset: 0x0010CEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationCoreChangeNotify()
		{
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x0010ED08 File Offset: 0x0010CF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationCoreChangeNotify(EntityFoundationCoreChangeNotify other) : this()
		{
			this.foundationEntityId_ = other.foundationEntityId_;
			this.hasFoundationCore_ = other.hasFoundationCore_;
			this.foundationCoreInfo_ = ((other.foundationCoreInfo_ != null) ? other.foundationCoreInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x0010ED60 File Offset: 0x0010CF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationCoreChangeNotify Clone()
		{
			return new EntityFoundationCoreChangeNotify(this);
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06006E0B RID: 28171 RVA: 0x0010ED68 File Offset: 0x0010CF68
		// (set) Token: 0x06006E0C RID: 28172 RVA: 0x0010ED70 File Offset: 0x0010CF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FoundationEntityId
		{
			get
			{
				return this.foundationEntityId_;
			}
			set
			{
				this.foundationEntityId_ = value;
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06006E0D RID: 28173 RVA: 0x0010ED79 File Offset: 0x0010CF79
		// (set) Token: 0x06006E0E RID: 28174 RVA: 0x0010ED81 File Offset: 0x0010CF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFoundationCore
		{
			get
			{
				return this.hasFoundationCore_;
			}
			set
			{
				this.hasFoundationCore_ = value;
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06006E0F RID: 28175 RVA: 0x0010ED8A File Offset: 0x0010CF8A
		// (set) Token: 0x06006E10 RID: 28176 RVA: 0x0010ED92 File Offset: 0x0010CF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo FoundationCoreInfo
		{
			get
			{
				return this.foundationCoreInfo_;
			}
			set
			{
				this.foundationCoreInfo_ = value;
			}
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x0010ED9B File Offset: 0x0010CF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityFoundationCoreChangeNotify);
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x0010EDAC File Offset: 0x0010CFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityFoundationCoreChangeNotify other)
		{
			return other != null && (other == this || (this.FoundationEntityId == other.FoundationEntityId && this.HasFoundationCore == other.HasFoundationCore && object.Equals(this.FoundationCoreInfo, other.FoundationCoreInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x0010EE0C File Offset: 0x0010D00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FoundationEntityId != 0)
			{
				num ^= this.FoundationEntityId.GetHashCode();
			}
			if (this.HasFoundationCore)
			{
				num ^= this.HasFoundationCore.GetHashCode();
			}
			if (this.foundationCoreInfo_ != null)
			{
				num ^= this.FoundationCoreInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x0010EE7A File Offset: 0x0010D07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x0010EE87 File Offset: 0x0010D087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E16 RID: 28182 RVA: 0x0010EE90 File Offset: 0x0010D090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.foundationCoreInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.FoundationCoreInfo);
			}
			if (this.FoundationEntityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.FoundationEntityId);
			}
			if (this.HasFoundationCore)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.HasFoundationCore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x0010EF08 File Offset: 0x0010D108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FoundationEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FoundationEntityId);
			}
			if (this.HasFoundationCore)
			{
				num += 2;
			}
			if (this.foundationCoreInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FoundationCoreInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x0010EF6C File Offset: 0x0010D16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityFoundationCoreChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FoundationEntityId != 0)
			{
				this.FoundationEntityId = other.FoundationEntityId;
			}
			if (other.HasFoundationCore)
			{
				this.HasFoundationCore = other.HasFoundationCore;
			}
			if (other.foundationCoreInfo_ != null)
			{
				if (this.foundationCoreInfo_ == null)
				{
					this.FoundationCoreInfo = new FoundationCoreInfo();
				}
				this.FoundationCoreInfo.MergeFrom(other.FoundationCoreInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E19 RID: 28185 RVA: 0x0010EFE8 File Offset: 0x0010D1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E1A RID: 28186 RVA: 0x0010EFF4 File Offset: 0x0010D1F4
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
				if (num != 26U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HasFoundationCore = input.ReadBool();
						}
					}
					else
					{
						this.FoundationEntityId = input.ReadInt32();
					}
				}
				else
				{
					if (this.foundationCoreInfo_ == null)
					{
						this.FoundationCoreInfo = new FoundationCoreInfo();
					}
					input.ReadMessage(this.FoundationCoreInfo);
				}
			}
		}

		// Token: 0x04003BE3 RID: 15331
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BE4 RID: 15332
		public const int FoundationEntityIdFieldNumber = 12;

		// Token: 0x04003BE5 RID: 15333
		private int foundationEntityId_;

		// Token: 0x04003BE6 RID: 15334
		public const int HasFoundationCoreFieldNumber = 14;

		// Token: 0x04003BE7 RID: 15335
		private bool hasFoundationCore_;

		// Token: 0x04003BE8 RID: 15336
		public const int FoundationCoreInfoFieldNumber = 3;

		// Token: 0x04003BE9 RID: 15337
		private FoundationCoreInfo foundationCoreInfo_;
	}
}
