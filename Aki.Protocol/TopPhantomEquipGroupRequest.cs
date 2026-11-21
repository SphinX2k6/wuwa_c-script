using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013FB RID: 5115
	[NetMessage(EMessageId.TopPhantomEquipGroupRequest)]
	public sealed class TopPhantomEquipGroupRequest : IMessage<TopPhantomEquipGroupRequest>, IMessage, IEquatable<TopPhantomEquipGroupRequest>, IDeepCloneable<TopPhantomEquipGroupRequest>, IBufferMessage
	{
		// Token: 0x0601B324 RID: 111396 RVA: 0x003F4F04 File Offset: 0x003F3104
		[NullableContext(1)]
		public static TopPhantomEquipGroupRequest Create()
		{
			return new TopPhantomEquipGroupRequest();
		}

		// Token: 0x17005C10 RID: 23568
		// (get) Token: 0x0601B325 RID: 111397 RVA: 0x003F4F0B File Offset: 0x003F310B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C11 RID: 23569
		// (get) Token: 0x0601B326 RID: 111398 RVA: 0x003F4F0E File Offset: 0x003F310E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TopPhantomEquipGroupRequest.Descriptor;
			}
		}

		// Token: 0x0601B327 RID: 111399 RVA: 0x003F4F15 File Offset: 0x003F3115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TopPhantomEquipGroupRequest()
		{
		}

		// Token: 0x0601B328 RID: 111400 RVA: 0x003F4F1D File Offset: 0x003F311D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TopPhantomEquipGroupRequest(TopPhantomEquipGroupRequest other) : this()
		{
			this.index_ = other.index_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B329 RID: 111401 RVA: 0x003F4F4E File Offset: 0x003F314E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TopPhantomEquipGroupRequest Clone()
		{
			return new TopPhantomEquipGroupRequest(this);
		}

		// Token: 0x17005C12 RID: 23570
		// (get) Token: 0x0601B32A RID: 111402 RVA: 0x003F4F56 File Offset: 0x003F3156
		// (set) Token: 0x0601B32B RID: 111403 RVA: 0x003F4F5E File Offset: 0x003F315E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17005C13 RID: 23571
		// (get) Token: 0x0601B32C RID: 111404 RVA: 0x003F4F67 File Offset: 0x003F3167
		// (set) Token: 0x0601B32D RID: 111405 RVA: 0x003F4F6F File Offset: 0x003F316F
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

		// Token: 0x0601B32E RID: 111406 RVA: 0x003F4F78 File Offset: 0x003F3178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TopPhantomEquipGroupRequest);
		}

		// Token: 0x0601B32F RID: 111407 RVA: 0x003F4F86 File Offset: 0x003F3186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TopPhantomEquipGroupRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B330 RID: 111408 RVA: 0x003F4FC4 File Offset: 0x003F31C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B331 RID: 111409 RVA: 0x003F501C File Offset: 0x003F321C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B332 RID: 111410 RVA: 0x003F5029 File Offset: 0x003F3229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B333 RID: 111411 RVA: 0x003F5034 File Offset: 0x003F3234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B334 RID: 111412 RVA: 0x003F508C File Offset: 0x003F328C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B335 RID: 111413 RVA: 0x003F50E4 File Offset: 0x003F32E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TopPhantomEquipGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B336 RID: 111414 RVA: 0x003F5134 File Offset: 0x003F3334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B337 RID: 111415 RVA: 0x003F5140 File Offset: 0x003F3340
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E96 RID: 40598
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E97 RID: 40599
		public const int IndexFieldNumber = 4;

		// Token: 0x04009E98 RID: 40600
		private int index_;

		// Token: 0x04009E99 RID: 40601
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04009E9A RID: 40602
		private int roleId_;
	}
}
