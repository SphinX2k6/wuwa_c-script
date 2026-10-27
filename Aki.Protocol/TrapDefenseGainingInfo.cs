using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001426 RID: 5158
	public sealed class TrapDefenseGainingInfo : IMessage<TrapDefenseGainingInfo>, IMessage, IEquatable<TrapDefenseGainingInfo>, IDeepCloneable<TrapDefenseGainingInfo>, IBufferMessage
	{
		// Token: 0x0601B55B RID: 111963 RVA: 0x003F5D2F File Offset: 0x003F3F2F
		[NullableContext(1)]
		public static TrapDefenseGainingInfo Create()
		{
			return new TrapDefenseGainingInfo();
		}

		// Token: 0x17005C32 RID: 23602
		// (get) Token: 0x0601B55C RID: 111964 RVA: 0x003F5D36 File Offset: 0x003F3F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseGainingInfo> Parser
		{
			get
			{
				return TrapDefenseGainingInfo._parser;
			}
		}

		// Token: 0x17005C33 RID: 23603
		// (get) Token: 0x0601B55D RID: 111965 RVA: 0x003F5D3D File Offset: 0x003F3F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C34 RID: 23604
		// (get) Token: 0x0601B55E RID: 111966 RVA: 0x003F5D40 File Offset: 0x003F3F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGainingInfo.Descriptor;
			}
		}

		// Token: 0x0601B55F RID: 111967 RVA: 0x003F5D47 File Offset: 0x003F3F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingInfo()
		{
		}

		// Token: 0x0601B560 RID: 111968 RVA: 0x003F5D4F File Offset: 0x003F3F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingInfo(TrapDefenseGainingInfo other) : this()
		{
			this.groupId_ = other.groupId_;
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B561 RID: 111969 RVA: 0x003F5D80 File Offset: 0x003F3F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingInfo Clone()
		{
			return new TrapDefenseGainingInfo(this);
		}

		// Token: 0x17005C35 RID: 23605
		// (get) Token: 0x0601B562 RID: 111970 RVA: 0x003F5D88 File Offset: 0x003F3F88
		// (set) Token: 0x0601B563 RID: 111971 RVA: 0x003F5D90 File Offset: 0x003F3F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17005C36 RID: 23606
		// (get) Token: 0x0601B564 RID: 111972 RVA: 0x003F5D99 File Offset: 0x003F3F99
		// (set) Token: 0x0601B565 RID: 111973 RVA: 0x003F5DA1 File Offset: 0x003F3FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x0601B566 RID: 111974 RVA: 0x003F5DAA File Offset: 0x003F3FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGainingInfo);
		}

		// Token: 0x0601B567 RID: 111975 RVA: 0x003F5DB8 File Offset: 0x003F3FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGainingInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B568 RID: 111976 RVA: 0x003F5DF8 File Offset: 0x003F3FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B569 RID: 111977 RVA: 0x003F5E50 File Offset: 0x003F4050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B56A RID: 111978 RVA: 0x003F5E5D File Offset: 0x003F405D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B56B RID: 111979 RVA: 0x003F5E68 File Offset: 0x003F4068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupId);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B56C RID: 111980 RVA: 0x003F5EC0 File Offset: 0x003F40C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B56D RID: 111981 RVA: 0x003F5F18 File Offset: 0x003F4118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGainingInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B56E RID: 111982 RVA: 0x003F5F68 File Offset: 0x003F4168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B56F RID: 111983 RVA: 0x003F5F74 File Offset: 0x003F4174
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
						this.LevelId = input.ReadInt32();
					}
				}
				else
				{
					this.GroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009DEF RID: 40431
		private static readonly MessageParser<TrapDefenseGainingInfo> _parser = new MessageParser<TrapDefenseGainingInfo>(() => new TrapDefenseGainingInfo());

		// Token: 0x04009DF0 RID: 40432
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DF1 RID: 40433
		public const int GroupIdFieldNumber = 1;

		// Token: 0x04009DF2 RID: 40434
		private int groupId_;

		// Token: 0x04009DF3 RID: 40435
		public const int LevelIdFieldNumber = 2;

		// Token: 0x04009DF4 RID: 40436
		private int levelId_;
	}
}
