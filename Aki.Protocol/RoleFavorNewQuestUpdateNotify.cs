using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001067 RID: 4199
	[NetMessage(EMessageId.RoleFavorNewQuestUpdateNotify)]
	public sealed class RoleFavorNewQuestUpdateNotify : IMessage<RoleFavorNewQuestUpdateNotify>, IMessage, IEquatable<RoleFavorNewQuestUpdateNotify>, IDeepCloneable<RoleFavorNewQuestUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016771 RID: 92017 RVA: 0x00344AF3 File Offset: 0x00342CF3
		[NullableContext(1)]
		public static RoleFavorNewQuestUpdateNotify Create()
		{
			return new RoleFavorNewQuestUpdateNotify();
		}

		// Token: 0x17004B3D RID: 19261
		// (get) Token: 0x06016772 RID: 92018 RVA: 0x00344AFA File Offset: 0x00342CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B3E RID: 19262
		// (get) Token: 0x06016773 RID: 92019 RVA: 0x00344AFD File Offset: 0x00342CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorNewQuestUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016774 RID: 92020 RVA: 0x00344B04 File Offset: 0x00342D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorNewQuestUpdateNotify()
		{
		}

		// Token: 0x06016775 RID: 92021 RVA: 0x00344B0C File Offset: 0x00342D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorNewQuestUpdateNotify(RoleFavorNewQuestUpdateNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.favorQuest_ = ((other.favorQuest_ != null) ? other.favorQuest_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016776 RID: 92022 RVA: 0x00344B58 File Offset: 0x00342D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorNewQuestUpdateNotify Clone()
		{
			return new RoleFavorNewQuestUpdateNotify(this);
		}

		// Token: 0x17004B3F RID: 19263
		// (get) Token: 0x06016777 RID: 92023 RVA: 0x00344B60 File Offset: 0x00342D60
		// (set) Token: 0x06016778 RID: 92024 RVA: 0x00344B68 File Offset: 0x00342D68
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

		// Token: 0x17004B40 RID: 19264
		// (get) Token: 0x06016779 RID: 92025 RVA: 0x00344B71 File Offset: 0x00342D71
		// (set) Token: 0x0601677A RID: 92026 RVA: 0x00344B79 File Offset: 0x00342D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorQuest FavorQuest
		{
			get
			{
				return this.favorQuest_;
			}
			set
			{
				this.favorQuest_ = value;
			}
		}

		// Token: 0x0601677B RID: 92027 RVA: 0x00344B82 File Offset: 0x00342D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorNewQuestUpdateNotify);
		}

		// Token: 0x0601677C RID: 92028 RVA: 0x00344B90 File Offset: 0x00342D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorNewQuestUpdateNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this.FavorQuest, other.FavorQuest) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601677D RID: 92029 RVA: 0x00344BE0 File Offset: 0x00342DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.favorQuest_ != null)
			{
				num ^= this.FavorQuest.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601677E RID: 92030 RVA: 0x00344C35 File Offset: 0x00342E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601677F RID: 92031 RVA: 0x00344C42 File Offset: 0x00342E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016780 RID: 92032 RVA: 0x00344C4C File Offset: 0x00342E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.favorQuest_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.FavorQuest);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016781 RID: 92033 RVA: 0x00344CA8 File Offset: 0x00342EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.favorQuest_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FavorQuest);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016782 RID: 92034 RVA: 0x00344D00 File Offset: 0x00342F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorNewQuestUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.favorQuest_ != null)
			{
				if (this.favorQuest_ == null)
				{
					this.FavorQuest = new FavorQuest();
				}
				this.FavorQuest.MergeFrom(other.FavorQuest);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016783 RID: 92035 RVA: 0x00344D68 File Offset: 0x00342F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016784 RID: 92036 RVA: 0x00344D74 File Offset: 0x00342F74
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
				if (num != 66U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					if (this.favorQuest_ == null)
					{
						this.FavorQuest = new FavorQuest();
					}
					input.ReadMessage(this.FavorQuest);
				}
			}
		}

		// Token: 0x040086D3 RID: 34515
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086D4 RID: 34516
		public const int RoleIdFieldNumber = 14;

		// Token: 0x040086D5 RID: 34517
		private int roleId_;

		// Token: 0x040086D6 RID: 34518
		public const int FavorQuestFieldNumber = 8;

		// Token: 0x040086D7 RID: 34519
		private FavorQuest favorQuest_;
	}
}
