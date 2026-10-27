using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000275 RID: 629
	public sealed class CharacterLookAtInfo : IMessage<CharacterLookAtInfo>, IMessage, IEquatable<CharacterLookAtInfo>, IDeepCloneable<CharacterLookAtInfo>, IBufferMessage
	{
		// Token: 0x06004221 RID: 16929 RVA: 0x000A231E File Offset: 0x000A051E
		[NullableContext(1)]
		public static CharacterLookAtInfo Create()
		{
			return new CharacterLookAtInfo();
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06004222 RID: 16930 RVA: 0x000A2325 File Offset: 0x000A0525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterLookAtInfo> Parser
		{
			get
			{
				return CharacterLookAtInfo._parser;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06004223 RID: 16931 RVA: 0x000A232C File Offset: 0x000A052C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06004224 RID: 16932 RVA: 0x000A232F File Offset: 0x000A052F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterLookAtInfo.Descriptor;
			}
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x000A2336 File Offset: 0x000A0536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLookAtInfo()
		{
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x000A2340 File Offset: 0x000A0540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLookAtInfo(CharacterLookAtInfo other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityId_ = other.entityId_;
			this.targetType_ = other.targetType_;
			this.targetEntityId_ = other.targetEntityId_;
			this.targetPos_ = ((other.targetPos_ != null) ? other.targetPos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x000A23B0 File Offset: 0x000A05B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLookAtInfo Clone()
		{
			return new CharacterLookAtInfo(this);
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x000A23B8 File Offset: 0x000A05B8
		// (set) Token: 0x06004229 RID: 16937 RVA: 0x000A23C0 File Offset: 0x000A05C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x0600422A RID: 16938 RVA: 0x000A23C9 File Offset: 0x000A05C9
		// (set) Token: 0x0600422B RID: 16939 RVA: 0x000A23D1 File Offset: 0x000A05D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetType
		{
			get
			{
				return this.targetType_;
			}
			set
			{
				this.targetType_ = value;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x0600422C RID: 16940 RVA: 0x000A23DA File Offset: 0x000A05DA
		// (set) Token: 0x0600422D RID: 16941 RVA: 0x000A23F2 File Offset: 0x000A05F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetEntityId
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.targetEntityId_;
				}
				return CharacterLookAtInfo.TargetEntityIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.targetEntityId_ = value;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x0600422E RID: 16942 RVA: 0x000A2409 File Offset: 0x000A0609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTargetEntityId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x000A2416 File Offset: 0x000A0616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTargetEntityId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06004230 RID: 16944 RVA: 0x000A2427 File Offset: 0x000A0627
		// (set) Token: 0x06004231 RID: 16945 RVA: 0x000A242F File Offset: 0x000A062F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector TargetPos
		{
			get
			{
				return this.targetPos_;
			}
			set
			{
				this.targetPos_ = value;
			}
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x000A2438 File Offset: 0x000A0638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterLookAtInfo);
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x000A2448 File Offset: 0x000A0648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterLookAtInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.TargetType == other.TargetType && this.TargetEntityId == other.TargetEntityId && object.Equals(this.TargetPos, other.TargetPos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x000A24B8 File Offset: 0x000A06B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.TargetType != 0)
			{
				num ^= this.TargetType.GetHashCode();
			}
			if (this.HasTargetEntityId)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this.targetPos_ != null)
			{
				num ^= this.TargetPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x000A253F File Offset: 0x000A073F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x000A254C File Offset: 0x000A074C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x000A2558 File Offset: 0x000A0758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityId);
			}
			if (this.TargetType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TargetType);
			}
			if (this.HasTargetEntityId)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetEntityId);
			}
			if (this.targetPos_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TargetPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x000A25E8 File Offset: 0x000A07E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this.TargetType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetType);
			}
			if (this.HasTargetEntityId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetEntityId);
			}
			if (this.targetPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x000A2670 File Offset: 0x000A0870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharacterLookAtInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			if (other.TargetType != 0)
			{
				this.TargetType = other.TargetType;
			}
			if (other.HasTargetEntityId)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			if (other.targetPos_ != null)
			{
				if (this.targetPos_ == null)
				{
					this.TargetPos = new Vector();
				}
				this.TargetPos.MergeFrom(other.TargetPos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x000A2700 File Offset: 0x000A0900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x000A270C File Offset: 0x000A090C
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
						this.EntityId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TargetType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TargetEntityId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						if (this.targetPos_ == null)
						{
							this.TargetPos = new Vector();
						}
						input.ReadMessage(this.TargetPos);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002DE8 RID: 11752
		private static readonly MessageParser<CharacterLookAtInfo> _parser = new MessageParser<CharacterLookAtInfo>(() => new CharacterLookAtInfo());

		// Token: 0x04002DE9 RID: 11753
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DEA RID: 11754
		private int _hasBits0;

		// Token: 0x04002DEB RID: 11755
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04002DEC RID: 11756
		private int entityId_;

		// Token: 0x04002DED RID: 11757
		public const int TargetTypeFieldNumber = 2;

		// Token: 0x04002DEE RID: 11758
		private int targetType_;

		// Token: 0x04002DEF RID: 11759
		public const int TargetEntityIdFieldNumber = 3;

		// Token: 0x04002DF0 RID: 11760
		private static readonly int TargetEntityIdDefaultValue = 0;

		// Token: 0x04002DF1 RID: 11761
		private int targetEntityId_;

		// Token: 0x04002DF2 RID: 11762
		public const int TargetPosFieldNumber = 4;

		// Token: 0x04002DF3 RID: 11763
		private Vector targetPos_;
	}
}
