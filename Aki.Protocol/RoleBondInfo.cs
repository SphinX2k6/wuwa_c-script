using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001046 RID: 4166
	public sealed class RoleBondInfo : IMessage<RoleBondInfo>, IMessage, IEquatable<RoleBondInfo>, IDeepCloneable<RoleBondInfo>, IBufferMessage
	{
		// Token: 0x0601649B RID: 91291 RVA: 0x0033DAFA File Offset: 0x0033BCFA
		[NullableContext(1)]
		public static RoleBondInfo Create()
		{
			return new RoleBondInfo();
		}

		// Token: 0x17004A91 RID: 19089
		// (get) Token: 0x0601649C RID: 91292 RVA: 0x0033DB01 File Offset: 0x0033BD01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleBondInfo> Parser
		{
			get
			{
				return RoleBondInfo._parser;
			}
		}

		// Token: 0x17004A92 RID: 19090
		// (get) Token: 0x0601649D RID: 91293 RVA: 0x0033DB08 File Offset: 0x0033BD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A93 RID: 19091
		// (get) Token: 0x0601649E RID: 91294 RVA: 0x0033DB0B File Offset: 0x0033BD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleBondInfo.Descriptor;
			}
		}

		// Token: 0x0601649F RID: 91295 RVA: 0x0033DB12 File Offset: 0x0033BD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfo()
		{
		}

		// Token: 0x060164A0 RID: 91296 RVA: 0x0033DB1C File Offset: 0x0033BD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfo(RoleBondInfo other) : this()
		{
			this.configId_ = other.configId_;
			this.level_ = other.level_;
			this.targetStar_ = other.targetStar_;
			this.curStar_ = other.curStar_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060164A1 RID: 91297 RVA: 0x0033DB70 File Offset: 0x0033BD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfo Clone()
		{
			return new RoleBondInfo(this);
		}

		// Token: 0x17004A94 RID: 19092
		// (get) Token: 0x060164A2 RID: 91298 RVA: 0x0033DB78 File Offset: 0x0033BD78
		// (set) Token: 0x060164A3 RID: 91299 RVA: 0x0033DB80 File Offset: 0x0033BD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17004A95 RID: 19093
		// (get) Token: 0x060164A4 RID: 91300 RVA: 0x0033DB89 File Offset: 0x0033BD89
		// (set) Token: 0x060164A5 RID: 91301 RVA: 0x0033DB91 File Offset: 0x0033BD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17004A96 RID: 19094
		// (get) Token: 0x060164A6 RID: 91302 RVA: 0x0033DB9A File Offset: 0x0033BD9A
		// (set) Token: 0x060164A7 RID: 91303 RVA: 0x0033DBA2 File Offset: 0x0033BDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetStar
		{
			get
			{
				return this.targetStar_;
			}
			set
			{
				this.targetStar_ = value;
			}
		}

		// Token: 0x17004A97 RID: 19095
		// (get) Token: 0x060164A8 RID: 91304 RVA: 0x0033DBAB File Offset: 0x0033BDAB
		// (set) Token: 0x060164A9 RID: 91305 RVA: 0x0033DBB3 File Offset: 0x0033BDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurStar
		{
			get
			{
				return this.curStar_;
			}
			set
			{
				this.curStar_ = value;
			}
		}

		// Token: 0x060164AA RID: 91306 RVA: 0x0033DBBC File Offset: 0x0033BDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleBondInfo);
		}

		// Token: 0x060164AB RID: 91307 RVA: 0x0033DBCC File Offset: 0x0033BDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleBondInfo other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.Level == other.Level && this.TargetStar == other.TargetStar && this.CurStar == other.CurStar && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060164AC RID: 91308 RVA: 0x0033DC38 File Offset: 0x0033BE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.TargetStar != 0)
			{
				num ^= this.TargetStar.GetHashCode();
			}
			if (this.CurStar != 0)
			{
				num ^= this.CurStar.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060164AD RID: 91309 RVA: 0x0033DCC2 File Offset: 0x0033BEC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060164AE RID: 91310 RVA: 0x0033DCCF File Offset: 0x0033BECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060164AF RID: 91311 RVA: 0x0033DCD8 File Offset: 0x0033BED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.TargetStar != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetStar);
			}
			if (this.CurStar != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurStar);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060164B0 RID: 91312 RVA: 0x0033DD68 File Offset: 0x0033BF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.TargetStar != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetStar);
			}
			if (this.CurStar != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurStar);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060164B1 RID: 91313 RVA: 0x0033DDF0 File Offset: 0x0033BFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleBondInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.TargetStar != 0)
			{
				this.TargetStar = other.TargetStar;
			}
			if (other.CurStar != 0)
			{
				this.CurStar = other.CurStar;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060164B2 RID: 91314 RVA: 0x0033DE68 File Offset: 0x0033C068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060164B3 RID: 91315 RVA: 0x0033DE74 File Offset: 0x0033C074
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
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TargetStar = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CurStar = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040085CA RID: 34250
		private static readonly MessageParser<RoleBondInfo> _parser = new MessageParser<RoleBondInfo>(() => new RoleBondInfo());

		// Token: 0x040085CB RID: 34251
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085CC RID: 34252
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040085CD RID: 34253
		private int configId_;

		// Token: 0x040085CE RID: 34254
		public const int LevelFieldNumber = 2;

		// Token: 0x040085CF RID: 34255
		private int level_;

		// Token: 0x040085D0 RID: 34256
		public const int TargetStarFieldNumber = 3;

		// Token: 0x040085D1 RID: 34257
		private int targetStar_;

		// Token: 0x040085D2 RID: 34258
		public const int CurStarFieldNumber = 4;

		// Token: 0x040085D3 RID: 34259
		private int curStar_;
	}
}
