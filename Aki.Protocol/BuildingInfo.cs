using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200020C RID: 524
	public sealed class BuildingInfo : IMessage<BuildingInfo>, IMessage, IEquatable<BuildingInfo>, IDeepCloneable<BuildingInfo>, IBufferMessage
	{
		// Token: 0x060039C7 RID: 14791 RVA: 0x000902A5 File Offset: 0x0008E4A5
		[NullableContext(1)]
		public static BuildingInfo Create()
		{
			return new BuildingInfo();
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x000902AC File Offset: 0x0008E4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuildingInfo> Parser
		{
			get
			{
				return BuildingInfo._parser;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060039C9 RID: 14793 RVA: 0x000902B3 File Offset: 0x0008E4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x000902B6 File Offset: 0x0008E4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildingInfo.Descriptor;
			}
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x000902BD File Offset: 0x0008E4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingInfo()
		{
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x000902C5 File Offset: 0x0008E4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingInfo(BuildingInfo other) : this()
		{
			this.buildingId_ = other.buildingId_;
			this.level_ = other.level_;
			this.isUnlock_ = other.isUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x00090302 File Offset: 0x0008E502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingInfo Clone()
		{
			return new BuildingInfo(this);
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x0009030A File Offset: 0x0008E50A
		// (set) Token: 0x060039CF RID: 14799 RVA: 0x00090312 File Offset: 0x0008E512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuildingId
		{
			get
			{
				return this.buildingId_;
			}
			set
			{
				this.buildingId_ = value;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x0009031B File Offset: 0x0008E51B
		// (set) Token: 0x060039D1 RID: 14801 RVA: 0x00090323 File Offset: 0x0008E523
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

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x0009032C File Offset: 0x0008E52C
		// (set) Token: 0x060039D3 RID: 14803 RVA: 0x00090334 File Offset: 0x0008E534
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

		// Token: 0x060039D4 RID: 14804 RVA: 0x0009033D File Offset: 0x0008E53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildingInfo);
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x0009034C File Offset: 0x0008E54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuildingInfo other)
		{
			return other != null && (other == this || (this.BuildingId == other.BuildingId && this.Level == other.Level && this.IsUnlock == other.IsUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x000903A8 File Offset: 0x0008E5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuildingId != 0)
			{
				num ^= this.BuildingId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x00090419 File Offset: 0x0008E619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x00090426 File Offset: 0x0008E626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x00090430 File Offset: 0x0008E630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuildingId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuildingId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x000904A4 File Offset: 0x0008E6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuildingId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuildingId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00090508 File Offset: 0x0008E708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuildingInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuildingId != 0)
			{
				this.BuildingId = other.BuildingId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x0009056C File Offset: 0x0008E76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x00090578 File Offset: 0x0008E778
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
							this.IsUnlock = input.ReadBool();
						}
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.BuildingId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002BA5 RID: 11173
		private static readonly MessageParser<BuildingInfo> _parser = new MessageParser<BuildingInfo>(() => new BuildingInfo());

		// Token: 0x04002BA6 RID: 11174
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BA7 RID: 11175
		public const int BuildingIdFieldNumber = 1;

		// Token: 0x04002BA8 RID: 11176
		private int buildingId_;

		// Token: 0x04002BA9 RID: 11177
		public const int LevelFieldNumber = 2;

		// Token: 0x04002BAA RID: 11178
		private int level_;

		// Token: 0x04002BAB RID: 11179
		public const int IsUnlockFieldNumber = 3;

		// Token: 0x04002BAC RID: 11180
		private bool isUnlock_;
	}
}
