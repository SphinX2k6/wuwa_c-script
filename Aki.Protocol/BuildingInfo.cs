using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000211 RID: 529
	public sealed class BuildingInfo : IMessage<BuildingInfo>, IMessage, IEquatable<BuildingInfo>, IDeepCloneable<BuildingInfo>, IBufferMessage
	{
		// Token: 0x06003A6C RID: 14956 RVA: 0x00091EB9 File Offset: 0x000900B9
		[NullableContext(1)]
		public static BuildingInfo Create()
		{
			return new BuildingInfo();
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06003A6D RID: 14957 RVA: 0x00091EC0 File Offset: 0x000900C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuildingInfo> Parser
		{
			get
			{
				return BuildingInfo._parser;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x00091EC7 File Offset: 0x000900C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06003A6F RID: 14959 RVA: 0x00091ECA File Offset: 0x000900CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildingInfo.Descriptor;
			}
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x00091ED1 File Offset: 0x000900D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingInfo()
		{
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x00091ED9 File Offset: 0x000900D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingInfo(BuildingInfo other) : this()
		{
			this.buildingId_ = other.buildingId_;
			this.level_ = other.level_;
			this.isUnlock_ = other.isUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x00091F16 File Offset: 0x00090116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingInfo Clone()
		{
			return new BuildingInfo(this);
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06003A73 RID: 14963 RVA: 0x00091F1E File Offset: 0x0009011E
		// (set) Token: 0x06003A74 RID: 14964 RVA: 0x00091F26 File Offset: 0x00090126
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

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06003A75 RID: 14965 RVA: 0x00091F2F File Offset: 0x0009012F
		// (set) Token: 0x06003A76 RID: 14966 RVA: 0x00091F37 File Offset: 0x00090137
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

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06003A77 RID: 14967 RVA: 0x00091F40 File Offset: 0x00090140
		// (set) Token: 0x06003A78 RID: 14968 RVA: 0x00091F48 File Offset: 0x00090148
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

		// Token: 0x06003A79 RID: 14969 RVA: 0x00091F51 File Offset: 0x00090151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildingInfo);
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x00091F60 File Offset: 0x00090160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuildingInfo other)
		{
			return other != null && (other == this || (this.BuildingId == other.BuildingId && this.Level == other.Level && this.IsUnlock == other.IsUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x00091FBC File Offset: 0x000901BC
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

		// Token: 0x06003A7C RID: 14972 RVA: 0x0009202D File Offset: 0x0009022D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x0009203A File Offset: 0x0009023A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A7E RID: 14974 RVA: 0x00092044 File Offset: 0x00090244
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

		// Token: 0x06003A7F RID: 14975 RVA: 0x000920B8 File Offset: 0x000902B8
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

		// Token: 0x06003A80 RID: 14976 RVA: 0x0009211C File Offset: 0x0009031C
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

		// Token: 0x06003A81 RID: 14977 RVA: 0x00092180 File Offset: 0x00090380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x0009218C File Offset: 0x0009038C
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

		// Token: 0x04002C27 RID: 11303
		private static readonly MessageParser<BuildingInfo> _parser = new MessageParser<BuildingInfo>(() => new BuildingInfo());

		// Token: 0x04002C28 RID: 11304
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C29 RID: 11305
		public const int BuildingIdFieldNumber = 1;

		// Token: 0x04002C2A RID: 11306
		private int buildingId_;

		// Token: 0x04002C2B RID: 11307
		public const int LevelFieldNumber = 2;

		// Token: 0x04002C2C RID: 11308
		private int level_;

		// Token: 0x04002C2D RID: 11309
		public const int IsUnlockFieldNumber = 3;

		// Token: 0x04002C2E RID: 11310
		private bool isUnlock_;
	}
}
