using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000277 RID: 631
	public sealed class CharacterMoveToPointConfig : IMessage<CharacterMoveToPointConfig>, IMessage, IEquatable<CharacterMoveToPointConfig>, IDeepCloneable<CharacterMoveToPointConfig>, IBufferMessage
	{
		// Token: 0x06004253 RID: 16979 RVA: 0x000A2B1F File Offset: 0x000A0D1F
		[NullableContext(1)]
		public static CharacterMoveToPointConfig Create()
		{
			return new CharacterMoveToPointConfig();
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06004254 RID: 16980 RVA: 0x000A2B26 File Offset: 0x000A0D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06004255 RID: 16981 RVA: 0x000A2B29 File Offset: 0x000A0D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterMoveToPointConfig.Descriptor;
			}
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x000A2B30 File Offset: 0x000A0D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointConfig()
		{
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x000A2B38 File Offset: 0x000A0D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointConfig(CharacterMoveToPointConfig other) : this()
		{
			this.targetPos_ = ((other.targetPos_ != null) ? other.targetPos_.Clone() : null);
			this.moveType_ = other.moveType_;
			this.isExact_ = other.isExact_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x000A2B90 File Offset: 0x000A0D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointConfig Clone()
		{
			return new CharacterMoveToPointConfig(this);
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06004259 RID: 16985 RVA: 0x000A2B98 File Offset: 0x000A0D98
		// (set) Token: 0x0600425A RID: 16986 RVA: 0x000A2BA0 File Offset: 0x000A0DA0
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

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x0600425B RID: 16987 RVA: 0x000A2BA9 File Offset: 0x000A0DA9
		// (set) Token: 0x0600425C RID: 16988 RVA: 0x000A2BB1 File Offset: 0x000A0DB1
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

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x0600425D RID: 16989 RVA: 0x000A2BBA File Offset: 0x000A0DBA
		// (set) Token: 0x0600425E RID: 16990 RVA: 0x000A2BC2 File Offset: 0x000A0DC2
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

		// Token: 0x0600425F RID: 16991 RVA: 0x000A2BCB File Offset: 0x000A0DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterMoveToPointConfig);
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x000A2BDC File Offset: 0x000A0DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterMoveToPointConfig other)
		{
			return other != null && (other == this || (object.Equals(this.TargetPos, other.TargetPos) && this.MoveType == other.MoveType && this.IsExact == other.IsExact && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x000A2C3C File Offset: 0x000A0E3C
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

		// Token: 0x06004262 RID: 16994 RVA: 0x000A2CAA File Offset: 0x000A0EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x000A2CB7 File Offset: 0x000A0EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x000A2CC0 File Offset: 0x000A0EC0
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

		// Token: 0x06004265 RID: 16997 RVA: 0x000A2D38 File Offset: 0x000A0F38
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

		// Token: 0x06004266 RID: 16998 RVA: 0x000A2D9C File Offset: 0x000A0F9C
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

		// Token: 0x06004267 RID: 16999 RVA: 0x000A2E18 File Offset: 0x000A1018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x000A2E24 File Offset: 0x000A1024
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

		// Token: 0x04002DFC RID: 11772
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DFD RID: 11773
		public const int TargetPosFieldNumber = 1;

		// Token: 0x04002DFE RID: 11774
		private Vector targetPos_;

		// Token: 0x04002DFF RID: 11775
		public const int MoveTypeFieldNumber = 2;

		// Token: 0x04002E00 RID: 11776
		private int moveType_;

		// Token: 0x04002E01 RID: 11777
		public const int IsExactFieldNumber = 3;

		// Token: 0x04002E02 RID: 11778
		private bool isExact_;
	}
}
