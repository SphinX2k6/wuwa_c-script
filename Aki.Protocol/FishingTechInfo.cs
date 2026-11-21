using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000576 RID: 1398
	public sealed class FishingTechInfo : IMessage<FishingTechInfo>, IMessage, IEquatable<FishingTechInfo>, IDeepCloneable<FishingTechInfo>, IBufferMessage
	{
		// Token: 0x06008230 RID: 33328 RVA: 0x0013A249 File Offset: 0x00138449
		[NullableContext(1)]
		public static FishingTechInfo Create()
		{
			return new FishingTechInfo();
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06008231 RID: 33329 RVA: 0x0013A250 File Offset: 0x00138450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingTechInfo> Parser
		{
			get
			{
				return FishingTechInfo._parser;
			}
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06008232 RID: 33330 RVA: 0x0013A257 File Offset: 0x00138457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06008233 RID: 33331 RVA: 0x0013A25A File Offset: 0x0013845A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTechInfo.Descriptor;
			}
		}

		// Token: 0x06008234 RID: 33332 RVA: 0x0013A261 File Offset: 0x00138461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfo()
		{
		}

		// Token: 0x06008235 RID: 33333 RVA: 0x0013A269 File Offset: 0x00138469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfo(FishingTechInfo other) : this()
		{
			this.nodeId_ = other.nodeId_;
			this.level_ = other.level_;
			this.unlock_ = other.unlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008236 RID: 33334 RVA: 0x0013A2A6 File Offset: 0x001384A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfo Clone()
		{
			return new FishingTechInfo(this);
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06008237 RID: 33335 RVA: 0x0013A2AE File Offset: 0x001384AE
		// (set) Token: 0x06008238 RID: 33336 RVA: 0x0013A2B6 File Offset: 0x001384B6
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

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06008239 RID: 33337 RVA: 0x0013A2BF File Offset: 0x001384BF
		// (set) Token: 0x0600823A RID: 33338 RVA: 0x0013A2C7 File Offset: 0x001384C7
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

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x0600823B RID: 33339 RVA: 0x0013A2D0 File Offset: 0x001384D0
		// (set) Token: 0x0600823C RID: 33340 RVA: 0x0013A2D8 File Offset: 0x001384D8
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

		// Token: 0x0600823D RID: 33341 RVA: 0x0013A2E1 File Offset: 0x001384E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTechInfo);
		}

		// Token: 0x0600823E RID: 33342 RVA: 0x0013A2F0 File Offset: 0x001384F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTechInfo other)
		{
			return other != null && (other == this || (this.NodeId == other.NodeId && this.Level == other.Level && this.Unlock == other.Unlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600823F RID: 33343 RVA: 0x0013A34C File Offset: 0x0013854C
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

		// Token: 0x06008240 RID: 33344 RVA: 0x0013A3BD File Offset: 0x001385BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008241 RID: 33345 RVA: 0x0013A3CA File Offset: 0x001385CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008242 RID: 33346 RVA: 0x0013A3D4 File Offset: 0x001385D4
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

		// Token: 0x06008243 RID: 33347 RVA: 0x0013A448 File Offset: 0x00138648
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

		// Token: 0x06008244 RID: 33348 RVA: 0x0013A4AC File Offset: 0x001386AC
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

		// Token: 0x06008245 RID: 33349 RVA: 0x0013A510 File Offset: 0x00138710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008246 RID: 33350 RVA: 0x0013A51C File Offset: 0x0013871C
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

		// Token: 0x04004176 RID: 16758
		private static readonly MessageParser<FishingTechInfo> _parser = new MessageParser<FishingTechInfo>(() => new FishingTechInfo());

		// Token: 0x04004177 RID: 16759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004178 RID: 16760
		public const int NodeIdFieldNumber = 1;

		// Token: 0x04004179 RID: 16761
		private int nodeId_;

		// Token: 0x0400417A RID: 16762
		public const int LevelFieldNumber = 2;

		// Token: 0x0400417B RID: 16763
		private int level_;

		// Token: 0x0400417C RID: 16764
		public const int UnlockFieldNumber = 3;

		// Token: 0x0400417D RID: 16765
		private bool unlock_;
	}
}
