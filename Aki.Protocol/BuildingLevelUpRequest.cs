using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000212 RID: 530
	[NetMessage(EMessageId.BuildingLevelUpRequest)]
	public sealed class BuildingLevelUpRequest : IMessage<BuildingLevelUpRequest>, IMessage, IEquatable<BuildingLevelUpRequest>, IDeepCloneable<BuildingLevelUpRequest>, IBufferMessage
	{
		// Token: 0x06003A84 RID: 14980 RVA: 0x00092212 File Offset: 0x00090412
		[NullableContext(1)]
		public static BuildingLevelUpRequest Create()
		{
			return new BuildingLevelUpRequest();
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06003A85 RID: 14981 RVA: 0x00092219 File Offset: 0x00090419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x0009221C File Offset: 0x0009041C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildingLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x00092223 File Offset: 0x00090423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingLevelUpRequest()
		{
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x0009222B File Offset: 0x0009042B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingLevelUpRequest(BuildingLevelUpRequest other) : this()
		{
			this.buildingId_ = other.buildingId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x00092250 File Offset: 0x00090450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingLevelUpRequest Clone()
		{
			return new BuildingLevelUpRequest(this);
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06003A8A RID: 14986 RVA: 0x00092258 File Offset: 0x00090458
		// (set) Token: 0x06003A8B RID: 14987 RVA: 0x00092260 File Offset: 0x00090460
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

		// Token: 0x06003A8C RID: 14988 RVA: 0x00092269 File Offset: 0x00090469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildingLevelUpRequest);
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x00092277 File Offset: 0x00090477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuildingLevelUpRequest other)
		{
			return other != null && (other == this || (this.BuildingId == other.BuildingId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x000922A8 File Offset: 0x000904A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuildingId != 0)
			{
				num ^= this.BuildingId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x000922E7 File Offset: 0x000904E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x000922F4 File Offset: 0x000904F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x000922FD File Offset: 0x000904FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuildingId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.BuildingId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x00092330 File Offset: 0x00090530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuildingId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuildingId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x0009236E File Offset: 0x0009056E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuildingLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuildingId != 0)
			{
				this.BuildingId = other.BuildingId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x0009239F File Offset: 0x0009059F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x000923A8 File Offset: 0x000905A8
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BuildingId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C2F RID: 11311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C30 RID: 11312
		public const int BuildingIdFieldNumber = 10;

		// Token: 0x04002C31 RID: 11313
		private int buildingId_;
	}
}
