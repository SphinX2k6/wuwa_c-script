using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C7 RID: 2503
	[NetMessage(EMessageId.MatchThreeStarRequest)]
	public sealed class MatchThreeStarRequest : IMessage<MatchThreeStarRequest>, IMessage, IEquatable<MatchThreeStarRequest>, IDeepCloneable<MatchThreeStarRequest>, IBufferMessage
	{
		// Token: 0x0600DB9F RID: 56223 RVA: 0x002040AC File Offset: 0x002022AC
		[NullableContext(1)]
		public static MatchThreeStarRequest Create()
		{
			return new MatchThreeStarRequest();
		}

		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x0600DBA0 RID: 56224 RVA: 0x002040B3 File Offset: 0x002022B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x0600DBA1 RID: 56225 RVA: 0x002040B6 File Offset: 0x002022B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeStarRequest.Descriptor;
			}
		}

		// Token: 0x0600DBA2 RID: 56226 RVA: 0x002040BD File Offset: 0x002022BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeStarRequest()
		{
		}

		// Token: 0x0600DBA3 RID: 56227 RVA: 0x002040C5 File Offset: 0x002022C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeStarRequest(MatchThreeStarRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this.joinRole_ = other.joinRole_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBA4 RID: 56228 RVA: 0x002040F6 File Offset: 0x002022F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeStarRequest Clone()
		{
			return new MatchThreeStarRequest(this);
		}

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x0600DBA5 RID: 56229 RVA: 0x002040FE File Offset: 0x002022FE
		// (set) Token: 0x0600DBA6 RID: 56230 RVA: 0x00204106 File Offset: 0x00202306
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

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x0600DBA7 RID: 56231 RVA: 0x0020410F File Offset: 0x0020230F
		// (set) Token: 0x0600DBA8 RID: 56232 RVA: 0x00204117 File Offset: 0x00202317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int JoinRole
		{
			get
			{
				return this.joinRole_;
			}
			set
			{
				this.joinRole_ = value;
			}
		}

		// Token: 0x0600DBA9 RID: 56233 RVA: 0x00204120 File Offset: 0x00202320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeStarRequest);
		}

		// Token: 0x0600DBAA RID: 56234 RVA: 0x0020412E File Offset: 0x0020232E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeStarRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.JoinRole == other.JoinRole && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBAB RID: 56235 RVA: 0x0020416C File Offset: 0x0020236C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.JoinRole != 0)
			{
				num ^= this.JoinRole.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DBAC RID: 56236 RVA: 0x002041C4 File Offset: 0x002023C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DBAD RID: 56237 RVA: 0x002041D1 File Offset: 0x002023D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBAE RID: 56238 RVA: 0x002041DC File Offset: 0x002023DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JoinRole != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.JoinRole);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DBAF RID: 56239 RVA: 0x00204238 File Offset: 0x00202438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.JoinRole != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.JoinRole);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DBB0 RID: 56240 RVA: 0x00204290 File Offset: 0x00202490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeStarRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.JoinRole != 0)
			{
				this.JoinRole = other.JoinRole;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DBB1 RID: 56241 RVA: 0x002042E0 File Offset: 0x002024E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBB2 RID: 56242 RVA: 0x002042EC File Offset: 0x002024EC
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
				if (num != 88U)
				{
					if (num != 104U)
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
					this.JoinRole = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B20 RID: 23328
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B21 RID: 23329
		public const int LevelIdFieldNumber = 13;

		// Token: 0x04005B22 RID: 23330
		private int levelId_;

		// Token: 0x04005B23 RID: 23331
		public const int JoinRoleFieldNumber = 11;

		// Token: 0x04005B24 RID: 23332
		private int joinRole_;
	}
}
