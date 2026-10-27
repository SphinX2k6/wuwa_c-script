using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001013 RID: 4115
	public sealed class RogueRoleInstData : IMessage<RogueRoleInstData>, IMessage, IEquatable<RogueRoleInstData>, IDeepCloneable<RogueRoleInstData>, IBufferMessage
	{
		// Token: 0x06016005 RID: 90117 RVA: 0x00332C98 File Offset: 0x00330E98
		[NullableContext(1)]
		public static RogueRoleInstData Create()
		{
			return new RogueRoleInstData();
		}

		// Token: 0x17004989 RID: 18825
		// (get) Token: 0x06016006 RID: 90118 RVA: 0x00332C9F File Offset: 0x00330E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueRoleInstData> Parser
		{
			get
			{
				return RogueRoleInstData._parser;
			}
		}

		// Token: 0x1700498A RID: 18826
		// (get) Token: 0x06016007 RID: 90119 RVA: 0x00332CA6 File Offset: 0x00330EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700498B RID: 18827
		// (get) Token: 0x06016008 RID: 90120 RVA: 0x00332CA9 File Offset: 0x00330EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueRoleInstData.Descriptor;
			}
		}

		// Token: 0x06016009 RID: 90121 RVA: 0x00332CB0 File Offset: 0x00330EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoleInstData()
		{
		}

		// Token: 0x0601600A RID: 90122 RVA: 0x00332CB8 File Offset: 0x00330EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoleInstData(RogueRoleInstData other) : this()
		{
			this.instId_ = other.instId_;
			this.isUnlock_ = other.isUnlock_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601600B RID: 90123 RVA: 0x00332CF5 File Offset: 0x00330EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoleInstData Clone()
		{
			return new RogueRoleInstData(this);
		}

		// Token: 0x1700498C RID: 18828
		// (get) Token: 0x0601600C RID: 90124 RVA: 0x00332CFD File Offset: 0x00330EFD
		// (set) Token: 0x0601600D RID: 90125 RVA: 0x00332D05 File Offset: 0x00330F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x1700498D RID: 18829
		// (get) Token: 0x0601600E RID: 90126 RVA: 0x00332D0E File Offset: 0x00330F0E
		// (set) Token: 0x0601600F RID: 90127 RVA: 0x00332D16 File Offset: 0x00330F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x1700498E RID: 18830
		// (get) Token: 0x06016010 RID: 90128 RVA: 0x00332D1F File Offset: 0x00330F1F
		// (set) Token: 0x06016011 RID: 90129 RVA: 0x00332D27 File Offset: 0x00330F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x06016012 RID: 90130 RVA: 0x00332D30 File Offset: 0x00330F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueRoleInstData);
		}

		// Token: 0x06016013 RID: 90131 RVA: 0x00332D40 File Offset: 0x00330F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueRoleInstData other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.IsUnlock == other.IsUnlock && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016014 RID: 90132 RVA: 0x00332D9C File Offset: 0x00330F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016015 RID: 90133 RVA: 0x00332E0D File Offset: 0x0033100D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016016 RID: 90134 RVA: 0x00332E1A File Offset: 0x0033101A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016017 RID: 90135 RVA: 0x00332E24 File Offset: 0x00331024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016018 RID: 90136 RVA: 0x00332E98 File Offset: 0x00331098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016019 RID: 90137 RVA: 0x00332EF0 File Offset: 0x003310F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueRoleInstData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601601A RID: 90138 RVA: 0x00332F54 File Offset: 0x00331154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601601B RID: 90139 RVA: 0x00332F60 File Offset: 0x00331160
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsFinish = input.ReadBool();
						}
					}
					else
					{
						this.IsUnlock = input.ReadBool();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040083F5 RID: 33781
		private static readonly MessageParser<RogueRoleInstData> _parser = new MessageParser<RogueRoleInstData>(() => new RogueRoleInstData());

		// Token: 0x040083F6 RID: 33782
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083F7 RID: 33783
		public const int InstIdFieldNumber = 1;

		// Token: 0x040083F8 RID: 33784
		private int instId_;

		// Token: 0x040083F9 RID: 33785
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x040083FA RID: 33786
		private bool isUnlock_;

		// Token: 0x040083FB RID: 33787
		public const int IsFinishFieldNumber = 3;

		// Token: 0x040083FC RID: 33788
		private bool isFinish_;
	}
}
