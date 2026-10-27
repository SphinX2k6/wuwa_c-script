using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001264 RID: 4708
	public sealed class SpawnerEntityInfo : IMessage<SpawnerEntityInfo>, IMessage, IEquatable<SpawnerEntityInfo>, IDeepCloneable<SpawnerEntityInfo>, IBufferMessage
	{
		// Token: 0x06019154 RID: 102740 RVA: 0x003A646A File Offset: 0x003A466A
		[NullableContext(1)]
		public static SpawnerEntityInfo Create()
		{
			return new SpawnerEntityInfo();
		}

		// Token: 0x1700549B RID: 21659
		// (get) Token: 0x06019155 RID: 102741 RVA: 0x003A6471 File Offset: 0x003A4671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpawnerEntityInfo> Parser
		{
			get
			{
				return SpawnerEntityInfo._parser;
			}
		}

		// Token: 0x1700549C RID: 21660
		// (get) Token: 0x06019156 RID: 102742 RVA: 0x003A6478 File Offset: 0x003A4678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700549D RID: 21661
		// (get) Token: 0x06019157 RID: 102743 RVA: 0x003A647B File Offset: 0x003A467B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpawnerEntityInfo.Descriptor;
			}
		}

		// Token: 0x06019158 RID: 102744 RVA: 0x003A6482 File Offset: 0x003A4682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpawnerEntityInfo()
		{
		}

		// Token: 0x06019159 RID: 102745 RVA: 0x003A648C File Offset: 0x003A468C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpawnerEntityInfo(SpawnerEntityInfo other) : this()
		{
			this.incId_ = other.incId_;
			this.groupTypes_ = ((other.groupTypes_ != null) ? other.groupTypes_.Clone() : null);
			if (other.SpawnerSubTypeCase == SpawnerEntityInfo.SpawnerSubTypeOneofCase.MatrixInfo)
			{
				this.MatrixInfo = other.MatrixInfo.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601915A RID: 102746 RVA: 0x003A64F2 File Offset: 0x003A46F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpawnerEntityInfo Clone()
		{
			return new SpawnerEntityInfo(this);
		}

		// Token: 0x1700549E RID: 21662
		// (get) Token: 0x0601915B RID: 102747 RVA: 0x003A64FA File Offset: 0x003A46FA
		// (set) Token: 0x0601915C RID: 102748 RVA: 0x003A6502 File Offset: 0x003A4702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x1700549F RID: 21663
		// (get) Token: 0x0601915D RID: 102749 RVA: 0x003A650B File Offset: 0x003A470B
		// (set) Token: 0x0601915E RID: 102750 RVA: 0x003A6513 File Offset: 0x003A4713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupTypesWrapper GroupTypes
		{
			get
			{
				return this.groupTypes_;
			}
			set
			{
				this.groupTypes_ = value;
			}
		}

		// Token: 0x170054A0 RID: 21664
		// (get) Token: 0x0601915F RID: 102751 RVA: 0x003A651C File Offset: 0x003A471C
		// (set) Token: 0x06019160 RID: 102752 RVA: 0x003A6534 File Offset: 0x003A4734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatrixInfo MatrixInfo
		{
			get
			{
				if (this.spawnerSubTypeCase_ != SpawnerEntityInfo.SpawnerSubTypeOneofCase.MatrixInfo)
				{
					return null;
				}
				return (MatrixInfo)this.spawnerSubType_;
			}
			set
			{
				this.spawnerSubType_ = value;
				this.spawnerSubTypeCase_ = ((value == null) ? SpawnerEntityInfo.SpawnerSubTypeOneofCase.None : SpawnerEntityInfo.SpawnerSubTypeOneofCase.MatrixInfo);
			}
		}

		// Token: 0x170054A1 RID: 21665
		// (get) Token: 0x06019161 RID: 102753 RVA: 0x003A654A File Offset: 0x003A474A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpawnerEntityInfo.SpawnerSubTypeOneofCase SpawnerSubTypeCase
		{
			get
			{
				return this.spawnerSubTypeCase_;
			}
		}

		// Token: 0x06019162 RID: 102754 RVA: 0x003A6552 File Offset: 0x003A4752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSpawnerSubType()
		{
			this.spawnerSubTypeCase_ = SpawnerEntityInfo.SpawnerSubTypeOneofCase.None;
			this.spawnerSubType_ = null;
		}

		// Token: 0x06019163 RID: 102755 RVA: 0x003A6562 File Offset: 0x003A4762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpawnerEntityInfo);
		}

		// Token: 0x06019164 RID: 102756 RVA: 0x003A6570 File Offset: 0x003A4770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpawnerEntityInfo other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this.GroupTypes, other.GroupTypes) && object.Equals(this.MatrixInfo, other.MatrixInfo) && this.SpawnerSubTypeCase == other.SpawnerSubTypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019165 RID: 102757 RVA: 0x003A65E4 File Offset: 0x003A47E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0L)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.groupTypes_ != null)
			{
				num ^= this.GroupTypes.GetHashCode();
			}
			if (this.spawnerSubTypeCase_ == SpawnerEntityInfo.SpawnerSubTypeOneofCase.MatrixInfo)
			{
				num ^= this.MatrixInfo.GetHashCode();
			}
			num ^= (int)this.spawnerSubTypeCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019166 RID: 102758 RVA: 0x003A6659 File Offset: 0x003A4859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019167 RID: 102759 RVA: 0x003A6666 File Offset: 0x003A4866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019168 RID: 102760 RVA: 0x003A6670 File Offset: 0x003A4870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.IncId);
			}
			if (this.groupTypes_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GroupTypes);
			}
			if (this.spawnerSubTypeCase_ == SpawnerEntityInfo.SpawnerSubTypeOneofCase.MatrixInfo)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MatrixInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019169 RID: 102761 RVA: 0x003A66E8 File Offset: 0x003A48E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.IncId);
			}
			if (this.groupTypes_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GroupTypes);
			}
			if (this.spawnerSubTypeCase_ == SpawnerEntityInfo.SpawnerSubTypeOneofCase.MatrixInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MatrixInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601916A RID: 102762 RVA: 0x003A6758 File Offset: 0x003A4958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpawnerEntityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0L)
			{
				this.IncId = other.IncId;
			}
			if (other.groupTypes_ != null)
			{
				if (this.groupTypes_ == null)
				{
					this.GroupTypes = new GroupTypesWrapper();
				}
				this.GroupTypes.MergeFrom(other.GroupTypes);
			}
			if (other.SpawnerSubTypeCase == SpawnerEntityInfo.SpawnerSubTypeOneofCase.MatrixInfo)
			{
				if (this.MatrixInfo == null)
				{
					this.MatrixInfo = new MatrixInfo();
				}
				this.MatrixInfo.MergeFrom(other.MatrixInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601916B RID: 102763 RVA: 0x003A67ED File Offset: 0x003A49ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601916C RID: 102764 RVA: 0x003A67F8 File Offset: 0x003A49F8
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
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							MatrixInfo matrixInfo = new MatrixInfo();
							if (this.spawnerSubTypeCase_ == SpawnerEntityInfo.SpawnerSubTypeOneofCase.MatrixInfo)
							{
								matrixInfo.MergeFrom(this.MatrixInfo);
							}
							input.ReadMessage(matrixInfo);
							this.MatrixInfo = matrixInfo;
						}
					}
					else
					{
						if (this.groupTypes_ == null)
						{
							this.GroupTypes = new GroupTypesWrapper();
						}
						input.ReadMessage(this.GroupTypes);
					}
				}
				else
				{
					this.IncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040093BF RID: 37823
		private static readonly MessageParser<SpawnerEntityInfo> _parser = new MessageParser<SpawnerEntityInfo>(() => new SpawnerEntityInfo());

		// Token: 0x040093C0 RID: 37824
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093C1 RID: 37825
		public const int IncIdFieldNumber = 1;

		// Token: 0x040093C2 RID: 37826
		private long incId_;

		// Token: 0x040093C3 RID: 37827
		public const int GroupTypesFieldNumber = 2;

		// Token: 0x040093C4 RID: 37828
		private GroupTypesWrapper groupTypes_;

		// Token: 0x040093C5 RID: 37829
		public const int MatrixInfoFieldNumber = 3;

		// Token: 0x040093C6 RID: 37830
		private object spawnerSubType_;

		// Token: 0x040093C7 RID: 37831
		private SpawnerEntityInfo.SpawnerSubTypeOneofCase spawnerSubTypeCase_;

		// Token: 0x020019A5 RID: 6565
		public enum SpawnerSubTypeOneofCase
		{
			// Token: 0x0400CA37 RID: 51767
			None,
			// Token: 0x0400CA38 RID: 51768
			MatrixInfo = 3
		}
	}
}
