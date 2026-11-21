using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001387 RID: 4999
	public sealed class SystemMarkHideInfoPb : IMessage<SystemMarkHideInfoPb>, IMessage, IEquatable<SystemMarkHideInfoPb>, IDeepCloneable<SystemMarkHideInfoPb>, IBufferMessage
	{
		// Token: 0x0601A9DD RID: 109021 RVA: 0x003E0BC1 File Offset: 0x003DEDC1
		[NullableContext(1)]
		public static SystemMarkHideInfoPb Create()
		{
			return new SystemMarkHideInfoPb();
		}

		// Token: 0x17005A1E RID: 23070
		// (get) Token: 0x0601A9DE RID: 109022 RVA: 0x003E0BC8 File Offset: 0x003DEDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SystemMarkHideInfoPb> Parser
		{
			get
			{
				return SystemMarkHideInfoPb._parser;
			}
		}

		// Token: 0x17005A1F RID: 23071
		// (get) Token: 0x0601A9DF RID: 109023 RVA: 0x003E0BCF File Offset: 0x003DEDCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A20 RID: 23072
		// (get) Token: 0x0601A9E0 RID: 109024 RVA: 0x003E0BD2 File Offset: 0x003DEDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SystemMarkHideInfoPb.Descriptor;
			}
		}

		// Token: 0x0601A9E1 RID: 109025 RVA: 0x003E0BD9 File Offset: 0x003DEDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SystemMarkHideInfoPb()
		{
		}

		// Token: 0x0601A9E2 RID: 109026 RVA: 0x003E0BEC File Offset: 0x003DEDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SystemMarkHideInfoPb(SystemMarkHideInfoPb other) : this()
		{
			this.mapId_ = other.mapId_;
			this.entityConfigId_ = other.entityConfigId_;
			this.hideInfo_ = other.hideInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A9E3 RID: 109027 RVA: 0x003E0C29 File Offset: 0x003DEE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SystemMarkHideInfoPb Clone()
		{
			return new SystemMarkHideInfoPb(this);
		}

		// Token: 0x17005A21 RID: 23073
		// (get) Token: 0x0601A9E4 RID: 109028 RVA: 0x003E0C31 File Offset: 0x003DEE31
		// (set) Token: 0x0601A9E5 RID: 109029 RVA: 0x003E0C39 File Offset: 0x003DEE39
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

		// Token: 0x17005A22 RID: 23074
		// (get) Token: 0x0601A9E6 RID: 109030 RVA: 0x003E0C42 File Offset: 0x003DEE42
		// (set) Token: 0x0601A9E7 RID: 109031 RVA: 0x003E0C4A File Offset: 0x003DEE4A
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

		// Token: 0x17005A23 RID: 23075
		// (get) Token: 0x0601A9E8 RID: 109032 RVA: 0x003E0C53 File Offset: 0x003DEE53
		// (set) Token: 0x0601A9E9 RID: 109033 RVA: 0x003E0C5B File Offset: 0x003DEE5B
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

		// Token: 0x0601A9EA RID: 109034 RVA: 0x003E0C6E File Offset: 0x003DEE6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SystemMarkHideInfoPb);
		}

		// Token: 0x0601A9EB RID: 109035 RVA: 0x003E0C7C File Offset: 0x003DEE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SystemMarkHideInfoPb other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && this.EntityConfigId == other.EntityConfigId && !(this.HideInfo != other.HideInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A9EC RID: 109036 RVA: 0x003E0CDC File Offset: 0x003DEEDC
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

		// Token: 0x0601A9ED RID: 109037 RVA: 0x003E0D4F File Offset: 0x003DEF4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A9EE RID: 109038 RVA: 0x003E0D5C File Offset: 0x003DEF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A9EF RID: 109039 RVA: 0x003E0D68 File Offset: 0x003DEF68
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

		// Token: 0x0601A9F0 RID: 109040 RVA: 0x003E0DE4 File Offset: 0x003DEFE4
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

		// Token: 0x0601A9F1 RID: 109041 RVA: 0x003E0E58 File Offset: 0x003DF058
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

		// Token: 0x0601A9F2 RID: 109042 RVA: 0x003E0EC1 File Offset: 0x003DF0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A9F3 RID: 109043 RVA: 0x003E0ECC File Offset: 0x003DF0CC
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

		// Token: 0x04009BF9 RID: 39929
		private static readonly MessageParser<SystemMarkHideInfoPb> _parser = new MessageParser<SystemMarkHideInfoPb>(() => new SystemMarkHideInfoPb());

		// Token: 0x04009BFA RID: 39930
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BFB RID: 39931
		public const int MapIdFieldNumber = 1;

		// Token: 0x04009BFC RID: 39932
		private int mapId_;

		// Token: 0x04009BFD RID: 39933
		public const int EntityConfigIdFieldNumber = 2;

		// Token: 0x04009BFE RID: 39934
		private int entityConfigId_;

		// Token: 0x04009BFF RID: 39935
		public const int HideInfoFieldNumber = 3;

		// Token: 0x04009C00 RID: 39936
		private string hideInfo_ = "";
	}
}
