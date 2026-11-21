using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001499 RID: 5273
	public sealed class TrapDefenseGainingInfo : IMessage<TrapDefenseGainingInfo>, IMessage, IEquatable<TrapDefenseGainingInfo>, IDeepCloneable<TrapDefenseGainingInfo>, IBufferMessage
	{
		// Token: 0x0601BFE6 RID: 114662 RVA: 0x00411003 File Offset: 0x0040F203
		[NullableContext(1)]
		public static TrapDefenseGainingInfo Create()
		{
			return new TrapDefenseGainingInfo();
		}

		// Token: 0x17005EC7 RID: 24263
		// (get) Token: 0x0601BFE7 RID: 114663 RVA: 0x0041100A File Offset: 0x0040F20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseGainingInfo> Parser
		{
			get
			{
				return TrapDefenseGainingInfo._parser;
			}
		}

		// Token: 0x17005EC8 RID: 24264
		// (get) Token: 0x0601BFE8 RID: 114664 RVA: 0x00411011 File Offset: 0x0040F211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EC9 RID: 24265
		// (get) Token: 0x0601BFE9 RID: 114665 RVA: 0x00411014 File Offset: 0x0040F214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGainingInfo.Descriptor;
			}
		}

		// Token: 0x0601BFEA RID: 114666 RVA: 0x0041101B File Offset: 0x0040F21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingInfo()
		{
		}

		// Token: 0x0601BFEB RID: 114667 RVA: 0x00411023 File Offset: 0x0040F223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingInfo(TrapDefenseGainingInfo other) : this()
		{
			this.groupId_ = other.groupId_;
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BFEC RID: 114668 RVA: 0x00411054 File Offset: 0x0040F254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingInfo Clone()
		{
			return new TrapDefenseGainingInfo(this);
		}

		// Token: 0x17005ECA RID: 24266
		// (get) Token: 0x0601BFED RID: 114669 RVA: 0x0041105C File Offset: 0x0040F25C
		// (set) Token: 0x0601BFEE RID: 114670 RVA: 0x00411064 File Offset: 0x0040F264
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

		// Token: 0x17005ECB RID: 24267
		// (get) Token: 0x0601BFEF RID: 114671 RVA: 0x0041106D File Offset: 0x0040F26D
		// (set) Token: 0x0601BFF0 RID: 114672 RVA: 0x00411075 File Offset: 0x0040F275
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

		// Token: 0x0601BFF1 RID: 114673 RVA: 0x0041107E File Offset: 0x0040F27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGainingInfo);
		}

		// Token: 0x0601BFF2 RID: 114674 RVA: 0x0041108C File Offset: 0x0040F28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGainingInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BFF3 RID: 114675 RVA: 0x004110CC File Offset: 0x0040F2CC
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

		// Token: 0x0601BFF4 RID: 114676 RVA: 0x00411124 File Offset: 0x0040F324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BFF5 RID: 114677 RVA: 0x00411131 File Offset: 0x0040F331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BFF6 RID: 114678 RVA: 0x0041113C File Offset: 0x0040F33C
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

		// Token: 0x0601BFF7 RID: 114679 RVA: 0x00411194 File Offset: 0x0040F394
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

		// Token: 0x0601BFF8 RID: 114680 RVA: 0x004111EC File Offset: 0x0040F3EC
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

		// Token: 0x0601BFF9 RID: 114681 RVA: 0x0041123C File Offset: 0x0040F43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BFFA RID: 114682 RVA: 0x00411248 File Offset: 0x0040F448
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

		// Token: 0x0400A236 RID: 41526
		private static readonly MessageParser<TrapDefenseGainingInfo> _parser = new MessageParser<TrapDefenseGainingInfo>(() => new TrapDefenseGainingInfo());

		// Token: 0x0400A237 RID: 41527
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A238 RID: 41528
		public const int GroupIdFieldNumber = 1;

		// Token: 0x0400A239 RID: 41529
		private int groupId_;

		// Token: 0x0400A23A RID: 41530
		public const int LevelIdFieldNumber = 2;

		// Token: 0x0400A23B RID: 41531
		private int levelId_;
	}
}
