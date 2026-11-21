using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200106E RID: 4206
	public sealed class RoleFlySkinChange : IMessage<RoleFlySkinChange>, IMessage, IEquatable<RoleFlySkinChange>, IDeepCloneable<RoleFlySkinChange>, IBufferMessage
	{
		// Token: 0x060167FF RID: 92159 RVA: 0x00345E19 File Offset: 0x00344019
		[NullableContext(1)]
		public static RoleFlySkinChange Create()
		{
			return new RoleFlySkinChange();
		}

		// Token: 0x17004B5A RID: 19290
		// (get) Token: 0x06016800 RID: 92160 RVA: 0x00345E20 File Offset: 0x00344020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleFlySkinChange> Parser
		{
			get
			{
				return RoleFlySkinChange._parser;
			}
		}

		// Token: 0x17004B5B RID: 19291
		// (get) Token: 0x06016801 RID: 92161 RVA: 0x00345E27 File Offset: 0x00344027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B5C RID: 19292
		// (get) Token: 0x06016802 RID: 92162 RVA: 0x00345E2A File Offset: 0x0034402A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFlySkinChange.Descriptor;
			}
		}

		// Token: 0x06016803 RID: 92163 RVA: 0x00345E31 File Offset: 0x00344031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlySkinChange()
		{
		}

		// Token: 0x06016804 RID: 92164 RVA: 0x00345E39 File Offset: 0x00344039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlySkinChange(RoleFlySkinChange other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016805 RID: 92165 RVA: 0x00345E6A File Offset: 0x0034406A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlySkinChange Clone()
		{
			return new RoleFlySkinChange(this);
		}

		// Token: 0x17004B5D RID: 19293
		// (get) Token: 0x06016806 RID: 92166 RVA: 0x00345E72 File Offset: 0x00344072
		// (set) Token: 0x06016807 RID: 92167 RVA: 0x00345E7A File Offset: 0x0034407A
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

		// Token: 0x17004B5E RID: 19294
		// (get) Token: 0x06016808 RID: 92168 RVA: 0x00345E83 File Offset: 0x00344083
		// (set) Token: 0x06016809 RID: 92169 RVA: 0x00345E8B File Offset: 0x0034408B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x0601680A RID: 92170 RVA: 0x00345E94 File Offset: 0x00344094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFlySkinChange);
		}

		// Token: 0x0601680B RID: 92171 RVA: 0x00345EA2 File Offset: 0x003440A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFlySkinChange other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601680C RID: 92172 RVA: 0x00345EE0 File Offset: 0x003440E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601680D RID: 92173 RVA: 0x00345F38 File Offset: 0x00344138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601680E RID: 92174 RVA: 0x00345F45 File Offset: 0x00344145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601680F RID: 92175 RVA: 0x00345F50 File Offset: 0x00344150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016810 RID: 92176 RVA: 0x00345FA8 File Offset: 0x003441A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016811 RID: 92177 RVA: 0x00346000 File Offset: 0x00344200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFlySkinChange other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016812 RID: 92178 RVA: 0x00346050 File Offset: 0x00344250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016813 RID: 92179 RVA: 0x0034605C File Offset: 0x0034425C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkinId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040086FA RID: 34554
		private static readonly MessageParser<RoleFlySkinChange> _parser = new MessageParser<RoleFlySkinChange>(() => new RoleFlySkinChange());

		// Token: 0x040086FB RID: 34555
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086FC RID: 34556
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040086FD RID: 34557
		private int roleId_;

		// Token: 0x040086FE RID: 34558
		public const int SkinIdFieldNumber = 2;

		// Token: 0x040086FF RID: 34559
		private int skinId_;
	}
}
