using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D3 RID: 4819
	public sealed class SpawnerEntityInfo : IMessage<SpawnerEntityInfo>, IMessage, IEquatable<SpawnerEntityInfo>, IDeepCloneable<SpawnerEntityInfo>, IBufferMessage
	{
		// Token: 0x06019B8A RID: 105354 RVA: 0x003C0BAE File Offset: 0x003BEDAE
		[NullableContext(1)]
		public static SpawnerEntityInfo Create()
		{
			return new SpawnerEntityInfo();
		}

		// Token: 0x1700571C RID: 22300
		// (get) Token: 0x06019B8B RID: 105355 RVA: 0x003C0BB5 File Offset: 0x003BEDB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpawnerEntityInfo> Parser
		{
			get
			{
				return SpawnerEntityInfo._parser;
			}
		}

		// Token: 0x1700571D RID: 22301
		// (get) Token: 0x06019B8C RID: 105356 RVA: 0x003C0BBC File Offset: 0x003BEDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700571E RID: 22302
		// (get) Token: 0x06019B8D RID: 105357 RVA: 0x003C0BBF File Offset: 0x003BEDBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpawnerEntityInfo.Descriptor;
			}
		}

		// Token: 0x06019B8E RID: 105358 RVA: 0x003C0BC6 File Offset: 0x003BEDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpawnerEntityInfo()
		{
		}

		// Token: 0x06019B8F RID: 105359 RVA: 0x003C0BD0 File Offset: 0x003BEDD0
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

		// Token: 0x06019B90 RID: 105360 RVA: 0x003C0C36 File Offset: 0x003BEE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpawnerEntityInfo Clone()
		{
			return new SpawnerEntityInfo(this);
		}

		// Token: 0x1700571F RID: 22303
		// (get) Token: 0x06019B91 RID: 105361 RVA: 0x003C0C3E File Offset: 0x003BEE3E
		// (set) Token: 0x06019B92 RID: 105362 RVA: 0x003C0C46 File Offset: 0x003BEE46
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

		// Token: 0x17005720 RID: 22304
		// (get) Token: 0x06019B93 RID: 105363 RVA: 0x003C0C4F File Offset: 0x003BEE4F
		// (set) Token: 0x06019B94 RID: 105364 RVA: 0x003C0C57 File Offset: 0x003BEE57
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

		// Token: 0x17005721 RID: 22305
		// (get) Token: 0x06019B95 RID: 105365 RVA: 0x003C0C60 File Offset: 0x003BEE60
		// (set) Token: 0x06019B96 RID: 105366 RVA: 0x003C0C78 File Offset: 0x003BEE78
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

		// Token: 0x17005722 RID: 22306
		// (get) Token: 0x06019B97 RID: 105367 RVA: 0x003C0C8E File Offset: 0x003BEE8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpawnerEntityInfo.SpawnerSubTypeOneofCase SpawnerSubTypeCase
		{
			get
			{
				return this.spawnerSubTypeCase_;
			}
		}

		// Token: 0x06019B98 RID: 105368 RVA: 0x003C0C96 File Offset: 0x003BEE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSpawnerSubType()
		{
			this.spawnerSubTypeCase_ = SpawnerEntityInfo.SpawnerSubTypeOneofCase.None;
			this.spawnerSubType_ = null;
		}

		// Token: 0x06019B99 RID: 105369 RVA: 0x003C0CA6 File Offset: 0x003BEEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpawnerEntityInfo);
		}

		// Token: 0x06019B9A RID: 105370 RVA: 0x003C0CB4 File Offset: 0x003BEEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpawnerEntityInfo other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this.GroupTypes, other.GroupTypes) && object.Equals(this.MatrixInfo, other.MatrixInfo) && this.SpawnerSubTypeCase == other.SpawnerSubTypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B9B RID: 105371 RVA: 0x003C0D28 File Offset: 0x003BEF28
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

		// Token: 0x06019B9C RID: 105372 RVA: 0x003C0D9D File Offset: 0x003BEF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B9D RID: 105373 RVA: 0x003C0DAA File Offset: 0x003BEFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B9E RID: 105374 RVA: 0x003C0DB4 File Offset: 0x003BEFB4
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

		// Token: 0x06019B9F RID: 105375 RVA: 0x003C0E2C File Offset: 0x003BF02C
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

		// Token: 0x06019BA0 RID: 105376 RVA: 0x003C0E9C File Offset: 0x003BF09C
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

		// Token: 0x06019BA1 RID: 105377 RVA: 0x003C0F31 File Offset: 0x003BF131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019BA2 RID: 105378 RVA: 0x003C0F3C File Offset: 0x003BF13C
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

		// Token: 0x040097E9 RID: 38889
		private static readonly MessageParser<SpawnerEntityInfo> _parser = new MessageParser<SpawnerEntityInfo>(() => new SpawnerEntityInfo());

		// Token: 0x040097EA RID: 38890
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097EB RID: 38891
		public const int IncIdFieldNumber = 1;

		// Token: 0x040097EC RID: 38892
		private long incId_;

		// Token: 0x040097ED RID: 38893
		public const int GroupTypesFieldNumber = 2;

		// Token: 0x040097EE RID: 38894
		private GroupTypesWrapper groupTypes_;

		// Token: 0x040097EF RID: 38895
		public const int MatrixInfoFieldNumber = 3;

		// Token: 0x040097F0 RID: 38896
		private object spawnerSubType_;

		// Token: 0x040097F1 RID: 38897
		private SpawnerEntityInfo.SpawnerSubTypeOneofCase spawnerSubTypeCase_;

		// Token: 0x02001A43 RID: 6723
		public enum SpawnerSubTypeOneofCase
		{
			// Token: 0x0400CF9E RID: 53150
			None,
			// Token: 0x0400CF9F RID: 53151
			MatrixInfo = 3
		}
	}
}
