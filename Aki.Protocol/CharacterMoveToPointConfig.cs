using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200027C RID: 636
	public sealed class CharacterMoveToPointConfig : IMessage<CharacterMoveToPointConfig>, IMessage, IEquatable<CharacterMoveToPointConfig>, IDeepCloneable<CharacterMoveToPointConfig>, IBufferMessage
	{
		// Token: 0x060042FA RID: 17146 RVA: 0x000A47EB File Offset: 0x000A29EB
		[NullableContext(1)]
		public static CharacterMoveToPointConfig Create()
		{
			return new CharacterMoveToPointConfig();
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060042FB RID: 17147 RVA: 0x000A47F2 File Offset: 0x000A29F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x000A47F5 File Offset: 0x000A29F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterMoveToPointConfig.Descriptor;
			}
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x000A47FC File Offset: 0x000A29FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointConfig()
		{
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x000A4804 File Offset: 0x000A2A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointConfig(CharacterMoveToPointConfig other) : this()
		{
			this.targetPos_ = ((other.targetPos_ != null) ? other.targetPos_.Clone() : null);
			this.moveType_ = other.moveType_;
			this.isExact_ = other.isExact_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x000A485C File Offset: 0x000A2A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointConfig Clone()
		{
			return new CharacterMoveToPointConfig(this);
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06004300 RID: 17152 RVA: 0x000A4864 File Offset: 0x000A2A64
		// (set) Token: 0x06004301 RID: 17153 RVA: 0x000A486C File Offset: 0x000A2A6C
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

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06004302 RID: 17154 RVA: 0x000A4875 File Offset: 0x000A2A75
		// (set) Token: 0x06004303 RID: 17155 RVA: 0x000A487D File Offset: 0x000A2A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoveType
		{
			get
			{
				return this.moveType_;
			}
			set
			{
				this.moveType_ = value;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x000A4886 File Offset: 0x000A2A86
		// (set) Token: 0x06004305 RID: 17157 RVA: 0x000A488E File Offset: 0x000A2A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsExact
		{
			get
			{
				return this.isExact_;
			}
			set
			{
				this.isExact_ = value;
			}
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x000A4897 File Offset: 0x000A2A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterMoveToPointConfig);
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x000A48A8 File Offset: 0x000A2AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterMoveToPointConfig other)
		{
			return other != null && (other == this || (object.Equals(this.TargetPos, other.TargetPos) && this.MoveType == other.MoveType && this.IsExact == other.IsExact && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x000A4908 File Offset: 0x000A2B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.targetPos_ != null)
			{
				num ^= this.TargetPos.GetHashCode();
			}
			if (this.MoveType != 0)
			{
				num ^= this.MoveType.GetHashCode();
			}
			if (this.IsExact)
			{
				num ^= this.IsExact.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x000A4976 File Offset: 0x000A2B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x000A4983 File Offset: 0x000A2B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x000A498C File Offset: 0x000A2B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.targetPos_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TargetPos);
			}
			if (this.MoveType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MoveType);
			}
			if (this.IsExact)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsExact);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x000A4A04 File Offset: 0x000A2C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.targetPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetPos);
			}
			if (this.MoveType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoveType);
			}
			if (this.IsExact)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x000A4A68 File Offset: 0x000A2C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharacterMoveToPointConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.targetPos_ != null)
			{
				if (this.targetPos_ == null)
				{
					this.TargetPos = new Vector();
				}
				this.TargetPos.MergeFrom(other.TargetPos);
			}
			if (other.MoveType != 0)
			{
				this.MoveType = other.MoveType;
			}
			if (other.IsExact)
			{
				this.IsExact = other.IsExact;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x000A4AE4 File Offset: 0x000A2CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x000A4AF0 File Offset: 0x000A2CF0
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsExact = input.ReadBool();
						}
					}
					else
					{
						this.MoveType = input.ReadInt32();
					}
				}
				else
				{
					if (this.targetPos_ == null)
					{
						this.TargetPos = new Vector();
					}
					input.ReadMessage(this.TargetPos);
				}
			}
		}

		// Token: 0x04002E80 RID: 11904
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E81 RID: 11905
		public const int TargetPosFieldNumber = 1;

		// Token: 0x04002E82 RID: 11906
		private Vector targetPos_;

		// Token: 0x04002E83 RID: 11907
		public const int MoveTypeFieldNumber = 2;

		// Token: 0x04002E84 RID: 11908
		private int moveType_;

		// Token: 0x04002E85 RID: 11909
		public const int IsExactFieldNumber = 3;

		// Token: 0x04002E86 RID: 11910
		private bool isExact_;
	}
}
