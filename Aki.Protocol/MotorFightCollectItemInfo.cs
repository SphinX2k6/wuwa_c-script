using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A2C RID: 2604
	public sealed class MotorFightCollectItemInfo : IMessage<MotorFightCollectItemInfo>, IMessage, IEquatable<MotorFightCollectItemInfo>, IDeepCloneable<MotorFightCollectItemInfo>, IBufferMessage
	{
		// Token: 0x0600E3C1 RID: 58305 RVA: 0x002154AF File Offset: 0x002136AF
		[NullableContext(1)]
		public static MotorFightCollectItemInfo Create()
		{
			return new MotorFightCollectItemInfo();
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x0600E3C2 RID: 58306 RVA: 0x002154B6 File Offset: 0x002136B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightCollectItemInfo> Parser
		{
			get
			{
				return MotorFightCollectItemInfo._parser;
			}
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x0600E3C3 RID: 58307 RVA: 0x002154BD File Offset: 0x002136BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x0600E3C4 RID: 58308 RVA: 0x002154C0 File Offset: 0x002136C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightCollectItemInfo.Descriptor;
			}
		}

		// Token: 0x0600E3C5 RID: 58309 RVA: 0x002154C7 File Offset: 0x002136C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectItemInfo()
		{
		}

		// Token: 0x0600E3C6 RID: 58310 RVA: 0x002154CF File Offset: 0x002136CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectItemInfo(MotorFightCollectItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3C7 RID: 58311 RVA: 0x00215500 File Offset: 0x00213700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectItemInfo Clone()
		{
			return new MotorFightCollectItemInfo(this);
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x0600E3C8 RID: 58312 RVA: 0x00215508 File Offset: 0x00213708
		// (set) Token: 0x0600E3C9 RID: 58313 RVA: 0x00215510 File Offset: 0x00213710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x0600E3CA RID: 58314 RVA: 0x00215519 File Offset: 0x00213719
		// (set) Token: 0x0600E3CB RID: 58315 RVA: 0x00215521 File Offset: 0x00213721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x0600E3CC RID: 58316 RVA: 0x0021552A File Offset: 0x0021372A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightCollectItemInfo);
		}

		// Token: 0x0600E3CD RID: 58317 RVA: 0x00215538 File Offset: 0x00213738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightCollectItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3CE RID: 58318 RVA: 0x00215578 File Offset: 0x00213778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E3CF RID: 58319 RVA: 0x002155D0 File Offset: 0x002137D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E3D0 RID: 58320 RVA: 0x002155DD File Offset: 0x002137DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3D1 RID: 58321 RVA: 0x002155E8 File Offset: 0x002137E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E3D2 RID: 58322 RVA: 0x00215640 File Offset: 0x00213840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E3D3 RID: 58323 RVA: 0x00215698 File Offset: 0x00213898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightCollectItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E3D4 RID: 58324 RVA: 0x002156E8 File Offset: 0x002138E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3D5 RID: 58325 RVA: 0x002156F4 File Offset: 0x002138F4
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005DA1 RID: 23969
		private static readonly MessageParser<MotorFightCollectItemInfo> _parser = new MessageParser<MotorFightCollectItemInfo>(() => new MotorFightCollectItemInfo());

		// Token: 0x04005DA2 RID: 23970
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DA3 RID: 23971
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04005DA4 RID: 23972
		private int itemId_;

		// Token: 0x04005DA5 RID: 23973
		public const int CountFieldNumber = 2;

		// Token: 0x04005DA6 RID: 23974
		private int count_;
	}
}
