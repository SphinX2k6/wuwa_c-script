using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DCD RID: 3533
	public sealed class PreheatSignNodeInfo : IMessage<PreheatSignNodeInfo>, IMessage, IEquatable<PreheatSignNodeInfo>, IDeepCloneable<PreheatSignNodeInfo>, IBufferMessage
	{
		// Token: 0x0601304F RID: 77903 RVA: 0x002C5ABD File Offset: 0x002C3CBD
		[NullableContext(1)]
		public static PreheatSignNodeInfo Create()
		{
			return new PreheatSignNodeInfo();
		}

		// Token: 0x17003F1B RID: 16155
		// (get) Token: 0x06013050 RID: 77904 RVA: 0x002C5AC4 File Offset: 0x002C3CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PreheatSignNodeInfo> Parser
		{
			get
			{
				return PreheatSignNodeInfo._parser;
			}
		}

		// Token: 0x17003F1C RID: 16156
		// (get) Token: 0x06013051 RID: 77905 RVA: 0x002C5ACB File Offset: 0x002C3CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F1D RID: 16157
		// (get) Token: 0x06013052 RID: 77906 RVA: 0x002C5ACE File Offset: 0x002C3CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignNodeInfo.Descriptor;
			}
		}

		// Token: 0x06013053 RID: 77907 RVA: 0x002C5AD5 File Offset: 0x002C3CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignNodeInfo()
		{
		}

		// Token: 0x06013054 RID: 77908 RVA: 0x002C5ADD File Offset: 0x002C3CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignNodeInfo(PreheatSignNodeInfo other) : this()
		{
			this.preheatNodeId_ = other.preheatNodeId_;
			this.unlockTime_ = other.unlockTime_;
			this.rewarded_ = other.rewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013055 RID: 77909 RVA: 0x002C5B1A File Offset: 0x002C3D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignNodeInfo Clone()
		{
			return new PreheatSignNodeInfo(this);
		}

		// Token: 0x17003F1E RID: 16158
		// (get) Token: 0x06013056 RID: 77910 RVA: 0x002C5B22 File Offset: 0x002C3D22
		// (set) Token: 0x06013057 RID: 77911 RVA: 0x002C5B2A File Offset: 0x002C3D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreheatNodeId
		{
			get
			{
				return this.preheatNodeId_;
			}
			set
			{
				this.preheatNodeId_ = value;
			}
		}

		// Token: 0x17003F1F RID: 16159
		// (get) Token: 0x06013058 RID: 77912 RVA: 0x002C5B33 File Offset: 0x002C3D33
		// (set) Token: 0x06013059 RID: 77913 RVA: 0x002C5B3B File Offset: 0x002C3D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x17003F20 RID: 16160
		// (get) Token: 0x0601305A RID: 77914 RVA: 0x002C5B44 File Offset: 0x002C3D44
		// (set) Token: 0x0601305B RID: 77915 RVA: 0x002C5B4C File Offset: 0x002C3D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Rewarded
		{
			get
			{
				return this.rewarded_;
			}
			set
			{
				this.rewarded_ = value;
			}
		}

		// Token: 0x0601305C RID: 77916 RVA: 0x002C5B55 File Offset: 0x002C3D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignNodeInfo);
		}

		// Token: 0x0601305D RID: 77917 RVA: 0x002C5B64 File Offset: 0x002C3D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignNodeInfo other)
		{
			return other != null && (other == this || (this.PreheatNodeId == other.PreheatNodeId && this.UnlockTime == other.UnlockTime && this.Rewarded == other.Rewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601305E RID: 77918 RVA: 0x002C5BC0 File Offset: 0x002C3DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PreheatNodeId != 0)
			{
				num ^= this.PreheatNodeId.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.Rewarded)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601305F RID: 77919 RVA: 0x002C5C31 File Offset: 0x002C3E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013060 RID: 77920 RVA: 0x002C5C3E File Offset: 0x002C3E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013061 RID: 77921 RVA: 0x002C5C48 File Offset: 0x002C3E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PreheatNodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PreheatNodeId);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.Rewarded)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Rewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013062 RID: 77922 RVA: 0x002C5CBC File Offset: 0x002C3EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PreheatNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreheatNodeId);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.Rewarded)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013063 RID: 77923 RVA: 0x002C5D20 File Offset: 0x002C3F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreheatSignNodeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PreheatNodeId != 0)
			{
				this.PreheatNodeId = other.PreheatNodeId;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.Rewarded)
			{
				this.Rewarded = other.Rewarded;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013064 RID: 77924 RVA: 0x002C5D84 File Offset: 0x002C3F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013065 RID: 77925 RVA: 0x002C5D90 File Offset: 0x002C3F90
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
							this.Rewarded = input.ReadBool();
						}
					}
					else
					{
						this.UnlockTime = input.ReadInt64();
					}
				}
				else
				{
					this.PreheatNodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007570 RID: 30064
		private static readonly MessageParser<PreheatSignNodeInfo> _parser = new MessageParser<PreheatSignNodeInfo>(() => new PreheatSignNodeInfo());

		// Token: 0x04007571 RID: 30065
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007572 RID: 30066
		public const int PreheatNodeIdFieldNumber = 1;

		// Token: 0x04007573 RID: 30067
		private int preheatNodeId_;

		// Token: 0x04007574 RID: 30068
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x04007575 RID: 30069
		private long unlockTime_;

		// Token: 0x04007576 RID: 30070
		public const int RewardedFieldNumber = 3;

		// Token: 0x04007577 RID: 30071
		private bool rewarded_;
	}
}
