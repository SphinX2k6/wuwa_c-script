using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200131A RID: 4890
	public sealed class SystemMarkHideInfoPb : IMessage<SystemMarkHideInfoPb>, IMessage, IEquatable<SystemMarkHideInfoPb>, IDeepCloneable<SystemMarkHideInfoPb>, IBufferMessage
	{
		// Token: 0x06019FCD RID: 106445 RVA: 0x003C6905 File Offset: 0x003C4B05
		[NullableContext(1)]
		public static SystemMarkHideInfoPb Create()
		{
			return new SystemMarkHideInfoPb();
		}

		// Token: 0x170057A4 RID: 22436
		// (get) Token: 0x06019FCE RID: 106446 RVA: 0x003C690C File Offset: 0x003C4B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SystemMarkHideInfoPb> Parser
		{
			get
			{
				return SystemMarkHideInfoPb._parser;
			}
		}

		// Token: 0x170057A5 RID: 22437
		// (get) Token: 0x06019FCF RID: 106447 RVA: 0x003C6913 File Offset: 0x003C4B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057A6 RID: 22438
		// (get) Token: 0x06019FD0 RID: 106448 RVA: 0x003C6916 File Offset: 0x003C4B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SystemMarkHideInfoPb.Descriptor;
			}
		}

		// Token: 0x06019FD1 RID: 106449 RVA: 0x003C691D File Offset: 0x003C4B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SystemMarkHideInfoPb()
		{
		}

		// Token: 0x06019FD2 RID: 106450 RVA: 0x003C6930 File Offset: 0x003C4B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SystemMarkHideInfoPb(SystemMarkHideInfoPb other) : this()
		{
			this.mapId_ = other.mapId_;
			this.entityConfigId_ = other.entityConfigId_;
			this.hideInfo_ = other.hideInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019FD3 RID: 106451 RVA: 0x003C696D File Offset: 0x003C4B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SystemMarkHideInfoPb Clone()
		{
			return new SystemMarkHideInfoPb(this);
		}

		// Token: 0x170057A7 RID: 22439
		// (get) Token: 0x06019FD4 RID: 106452 RVA: 0x003C6975 File Offset: 0x003C4B75
		// (set) Token: 0x06019FD5 RID: 106453 RVA: 0x003C697D File Offset: 0x003C4B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x170057A8 RID: 22440
		// (get) Token: 0x06019FD6 RID: 106454 RVA: 0x003C6986 File Offset: 0x003C4B86
		// (set) Token: 0x06019FD7 RID: 106455 RVA: 0x003C698E File Offset: 0x003C4B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x170057A9 RID: 22441
		// (get) Token: 0x06019FD8 RID: 106456 RVA: 0x003C6997 File Offset: 0x003C4B97
		// (set) Token: 0x06019FD9 RID: 106457 RVA: 0x003C699F File Offset: 0x003C4B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string HideInfo
		{
			get
			{
				return this.hideInfo_;
			}
			set
			{
				this.hideInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06019FDA RID: 106458 RVA: 0x003C69B2 File Offset: 0x003C4BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SystemMarkHideInfoPb);
		}

		// Token: 0x06019FDB RID: 106459 RVA: 0x003C69C0 File Offset: 0x003C4BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SystemMarkHideInfoPb other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && this.EntityConfigId == other.EntityConfigId && !(this.HideInfo != other.HideInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019FDC RID: 106460 RVA: 0x003C6A20 File Offset: 0x003C4C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.HideInfo.Length != 0)
			{
				num ^= this.HideInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019FDD RID: 106461 RVA: 0x003C6A93 File Offset: 0x003C4C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019FDE RID: 106462 RVA: 0x003C6AA0 File Offset: 0x003C4CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019FDF RID: 106463 RVA: 0x003C6AAC File Offset: 0x003C4CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MapId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MapId);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.HideInfo.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.HideInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019FE0 RID: 106464 RVA: 0x003C6B28 File Offset: 0x003C4D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.HideInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HideInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019FE1 RID: 106465 RVA: 0x003C6B9C File Offset: 0x003C4D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SystemMarkHideInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.HideInfo.Length != 0)
			{
				this.HideInfo = other.HideInfo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019FE2 RID: 106466 RVA: 0x003C6C05 File Offset: 0x003C4E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019FE3 RID: 106467 RVA: 0x003C6C10 File Offset: 0x003C4E10
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HideInfo = input.ReadString();
						}
					}
					else
					{
						this.EntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.MapId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040097D7 RID: 38871
		private static readonly MessageParser<SystemMarkHideInfoPb> _parser = new MessageParser<SystemMarkHideInfoPb>(() => new SystemMarkHideInfoPb());

		// Token: 0x040097D8 RID: 38872
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097D9 RID: 38873
		public const int MapIdFieldNumber = 1;

		// Token: 0x040097DA RID: 38874
		private int mapId_;

		// Token: 0x040097DB RID: 38875
		public const int EntityConfigIdFieldNumber = 2;

		// Token: 0x040097DC RID: 38876
		private int entityConfigId_;

		// Token: 0x040097DD RID: 38877
		public const int HideInfoFieldNumber = 3;

		// Token: 0x040097DE RID: 38878
		private string hideInfo_ = "";
	}
}
