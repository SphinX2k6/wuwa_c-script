using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001077 RID: 4215
	[NetMessage(EMessageId.RoleFavorNewQuestUpdateNotify)]
	public sealed class RoleFavorNewQuestUpdateNotify : IMessage<RoleFavorNewQuestUpdateNotify>, IMessage, IEquatable<RoleFavorNewQuestUpdateNotify>, IDeepCloneable<RoleFavorNewQuestUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016856 RID: 92246 RVA: 0x003461C7 File Offset: 0x003443C7
		[NullableContext(1)]
		public static RoleFavorNewQuestUpdateNotify Create()
		{
			return new RoleFavorNewQuestUpdateNotify();
		}

		// Token: 0x17004B67 RID: 19303
		// (get) Token: 0x06016857 RID: 92247 RVA: 0x003461CE File Offset: 0x003443CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B68 RID: 19304
		// (get) Token: 0x06016858 RID: 92248 RVA: 0x003461D1 File Offset: 0x003443D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorNewQuestUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016859 RID: 92249 RVA: 0x003461D8 File Offset: 0x003443D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorNewQuestUpdateNotify()
		{
		}

		// Token: 0x0601685A RID: 92250 RVA: 0x003461E0 File Offset: 0x003443E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorNewQuestUpdateNotify(RoleFavorNewQuestUpdateNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.favorQuest_ = ((other.favorQuest_ != null) ? other.favorQuest_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601685B RID: 92251 RVA: 0x0034622C File Offset: 0x0034442C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorNewQuestUpdateNotify Clone()
		{
			return new RoleFavorNewQuestUpdateNotify(this);
		}

		// Token: 0x17004B69 RID: 19305
		// (get) Token: 0x0601685C RID: 92252 RVA: 0x00346234 File Offset: 0x00344434
		// (set) Token: 0x0601685D RID: 92253 RVA: 0x0034623C File Offset: 0x0034443C
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

		// Token: 0x17004B6A RID: 19306
		// (get) Token: 0x0601685E RID: 92254 RVA: 0x00346245 File Offset: 0x00344445
		// (set) Token: 0x0601685F RID: 92255 RVA: 0x0034624D File Offset: 0x0034444D
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

		// Token: 0x06016860 RID: 92256 RVA: 0x00346256 File Offset: 0x00344456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorNewQuestUpdateNotify);
		}

		// Token: 0x06016861 RID: 92257 RVA: 0x00346264 File Offset: 0x00344464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorNewQuestUpdateNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this.FavorQuest, other.FavorQuest) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016862 RID: 92258 RVA: 0x003462B4 File Offset: 0x003444B4
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

		// Token: 0x06016863 RID: 92259 RVA: 0x00346309 File Offset: 0x00344509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016864 RID: 92260 RVA: 0x00346316 File Offset: 0x00344516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016865 RID: 92261 RVA: 0x00346320 File Offset: 0x00344520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.favorQuest_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FavorQuest);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016866 RID: 92262 RVA: 0x0034637C File Offset: 0x0034457C
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

		// Token: 0x06016867 RID: 92263 RVA: 0x003463D4 File Offset: 0x003445D4
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

		// Token: 0x06016868 RID: 92264 RVA: 0x0034643C File Offset: 0x0034463C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016869 RID: 92265 RVA: 0x00346448 File Offset: 0x00344648
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
				if (num != 10U)
				{
					if (num != 56U)
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

		// Token: 0x040086A9 RID: 34473
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086AA RID: 34474
		public const int RoleIdFieldNumber = 7;

		// Token: 0x040086AB RID: 34475
		private int roleId_;

		// Token: 0x040086AC RID: 34476
		public const int FavorQuestFieldNumber = 1;

		// Token: 0x040086AD RID: 34477
		private FavorQuest favorQuest_;
	}
}
