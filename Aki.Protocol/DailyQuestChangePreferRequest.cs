using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200032C RID: 812
	[NetMessage(EMessageId.DailyQuestChangePreferRequest)]
	public sealed class DailyQuestChangePreferRequest : IMessage<DailyQuestChangePreferRequest>, IMessage, IEquatable<DailyQuestChangePreferRequest>, IDeepCloneable<DailyQuestChangePreferRequest>, IBufferMessage
	{
		// Token: 0x060051BD RID: 20925 RVA: 0x000C7359 File Offset: 0x000C5559
		[NullableContext(1)]
		public static DailyQuestChangePreferRequest Create()
		{
			return new DailyQuestChangePreferRequest();
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x060051BE RID: 20926 RVA: 0x000C7360 File Offset: 0x000C5560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x060051BF RID: 20927 RVA: 0x000C7363 File Offset: 0x000C5563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestChangePreferRequest.Descriptor;
			}
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x000C736A File Offset: 0x000C556A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestChangePreferRequest()
		{
		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x000C7372 File Offset: 0x000C5572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestChangePreferRequest(DailyQuestChangePreferRequest other) : this()
		{
			this.targetArea_ = other.targetArea_;
			this.targetInfluence_ = other.targetInfluence_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x000C73A3 File Offset: 0x000C55A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestChangePreferRequest Clone()
		{
			return new DailyQuestChangePreferRequest(this);
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x060051C3 RID: 20931 RVA: 0x000C73AB File Offset: 0x000C55AB
		// (set) Token: 0x060051C4 RID: 20932 RVA: 0x000C73B3 File Offset: 0x000C55B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetArea
		{
			get
			{
				return this.targetArea_;
			}
			set
			{
				this.targetArea_ = value;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x060051C5 RID: 20933 RVA: 0x000C73BC File Offset: 0x000C55BC
		// (set) Token: 0x060051C6 RID: 20934 RVA: 0x000C73C4 File Offset: 0x000C55C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetInfluence
		{
			get
			{
				return this.targetInfluence_;
			}
			set
			{
				this.targetInfluence_ = value;
			}
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x000C73CD File Offset: 0x000C55CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestChangePreferRequest);
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x000C73DB File Offset: 0x000C55DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestChangePreferRequest other)
		{
			return other != null && (other == this || (this.TargetArea == other.TargetArea && this.TargetInfluence == other.TargetInfluence && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x000C741C File Offset: 0x000C561C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetArea != 0)
			{
				num ^= this.TargetArea.GetHashCode();
			}
			if (this.TargetInfluence != 0)
			{
				num ^= this.TargetInfluence.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x000C7474 File Offset: 0x000C5674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x000C7481 File Offset: 0x000C5681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x000C748C File Offset: 0x000C568C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetArea != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TargetArea);
			}
			if (this.TargetInfluence != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TargetInfluence);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x000C74E8 File Offset: 0x000C56E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetArea != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetArea);
			}
			if (this.TargetInfluence != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetInfluence);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x000C7540 File Offset: 0x000C5740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyQuestChangePreferRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetArea != 0)
			{
				this.TargetArea = other.TargetArea;
			}
			if (other.TargetInfluence != 0)
			{
				this.TargetInfluence = other.TargetInfluence;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x000C7590 File Offset: 0x000C5790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x000C759C File Offset: 0x000C579C
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
				if (num != 48U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetInfluence = input.ReadInt32();
					}
				}
				else
				{
					this.TargetArea = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003317 RID: 13079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003318 RID: 13080
		public const int TargetAreaFieldNumber = 6;

		// Token: 0x04003319 RID: 13081
		private int targetArea_;

		// Token: 0x0400331A RID: 13082
		public const int TargetInfluenceFieldNumber = 12;

		// Token: 0x0400331B RID: 13083
		private int targetInfluence_;
	}
}
