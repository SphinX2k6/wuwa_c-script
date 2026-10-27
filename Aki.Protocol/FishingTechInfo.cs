using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200058B RID: 1419
	public sealed class FishingTechInfo : IMessage<FishingTechInfo>, IMessage, IEquatable<FishingTechInfo>, IDeepCloneable<FishingTechInfo>, IBufferMessage
	{
		// Token: 0x06008398 RID: 33688 RVA: 0x0013CE55 File Offset: 0x0013B055
		[NullableContext(1)]
		public static FishingTechInfo Create()
		{
			return new FishingTechInfo();
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06008399 RID: 33689 RVA: 0x0013CE5C File Offset: 0x0013B05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingTechInfo> Parser
		{
			get
			{
				return FishingTechInfo._parser;
			}
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x0600839A RID: 33690 RVA: 0x0013CE63 File Offset: 0x0013B063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x0600839B RID: 33691 RVA: 0x0013CE66 File Offset: 0x0013B066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTechInfo.Descriptor;
			}
		}

		// Token: 0x0600839C RID: 33692 RVA: 0x0013CE6D File Offset: 0x0013B06D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfo()
		{
		}

		// Token: 0x0600839D RID: 33693 RVA: 0x0013CE75 File Offset: 0x0013B075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfo(FishingTechInfo other) : this()
		{
			this.nodeId_ = other.nodeId_;
			this.level_ = other.level_;
			this.unlock_ = other.unlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600839E RID: 33694 RVA: 0x0013CEB2 File Offset: 0x0013B0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfo Clone()
		{
			return new FishingTechInfo(this);
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x0600839F RID: 33695 RVA: 0x0013CEBA File Offset: 0x0013B0BA
		// (set) Token: 0x060083A0 RID: 33696 RVA: 0x0013CEC2 File Offset: 0x0013B0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x060083A1 RID: 33697 RVA: 0x0013CECB File Offset: 0x0013B0CB
		// (set) Token: 0x060083A2 RID: 33698 RVA: 0x0013CED3 File Offset: 0x0013B0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x060083A3 RID: 33699 RVA: 0x0013CEDC File Offset: 0x0013B0DC
		// (set) Token: 0x060083A4 RID: 33700 RVA: 0x0013CEE4 File Offset: 0x0013B0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlock
		{
			get
			{
				return this.unlock_;
			}
			set
			{
				this.unlock_ = value;
			}
		}

		// Token: 0x060083A5 RID: 33701 RVA: 0x0013CEED File Offset: 0x0013B0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTechInfo);
		}

		// Token: 0x060083A6 RID: 33702 RVA: 0x0013CEFC File Offset: 0x0013B0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTechInfo other)
		{
			return other != null && (other == this || (this.NodeId == other.NodeId && this.Level == other.Level && this.Unlock == other.Unlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083A7 RID: 33703 RVA: 0x0013CF58 File Offset: 0x0013B158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083A8 RID: 33704 RVA: 0x0013CFC9 File Offset: 0x0013B1C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060083A9 RID: 33705 RVA: 0x0013CFD6 File Offset: 0x0013B1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083AA RID: 33706 RVA: 0x0013CFE0 File Offset: 0x0013B1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NodeId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.Unlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Unlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083AB RID: 33707 RVA: 0x0013D054 File Offset: 0x0013B254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Unlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083AC RID: 33708 RVA: 0x0013D0B8 File Offset: 0x0013B2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingTechInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060083AD RID: 33709 RVA: 0x0013D11C File Offset: 0x0013B31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083AE RID: 33710 RVA: 0x0013D128 File Offset: 0x0013B328
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
							this.Unlock = input.ReadBool();
						}
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.NodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004180 RID: 16768
		private static readonly MessageParser<FishingTechInfo> _parser = new MessageParser<FishingTechInfo>(() => new FishingTechInfo());

		// Token: 0x04004181 RID: 16769
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004182 RID: 16770
		public const int NodeIdFieldNumber = 1;

		// Token: 0x04004183 RID: 16771
		private int nodeId_;

		// Token: 0x04004184 RID: 16772
		public const int LevelFieldNumber = 2;

		// Token: 0x04004185 RID: 16773
		private int level_;

		// Token: 0x04004186 RID: 16774
		public const int UnlockFieldNumber = 3;

		// Token: 0x04004187 RID: 16775
		private bool unlock_;
	}
}
