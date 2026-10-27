using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200020F RID: 527
	[NetMessage(EMessageId.BuildingUnLockRequest)]
	public sealed class BuildingUnLockRequest : IMessage<BuildingUnLockRequest>, IMessage, IEquatable<BuildingUnLockRequest>, IDeepCloneable<BuildingUnLockRequest>, IBufferMessage
	{
		// Token: 0x06003A07 RID: 14855 RVA: 0x00090B72 File Offset: 0x0008ED72
		[NullableContext(1)]
		public static BuildingUnLockRequest Create()
		{
			return new BuildingUnLockRequest();
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06003A08 RID: 14856 RVA: 0x00090B79 File Offset: 0x0008ED79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x00090B7C File Offset: 0x0008ED7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildingUnLockRequest.Descriptor;
			}
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x00090B83 File Offset: 0x0008ED83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingUnLockRequest()
		{
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x00090B8B File Offset: 0x0008ED8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingUnLockRequest(BuildingUnLockRequest other) : this()
		{
			this.buildingId_ = other.buildingId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x00090BB0 File Offset: 0x0008EDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingUnLockRequest Clone()
		{
			return new BuildingUnLockRequest(this);
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06003A0D RID: 14861 RVA: 0x00090BB8 File Offset: 0x0008EDB8
		// (set) Token: 0x06003A0E RID: 14862 RVA: 0x00090BC0 File Offset: 0x0008EDC0
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

		// Token: 0x06003A0F RID: 14863 RVA: 0x00090BC9 File Offset: 0x0008EDC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildingUnLockRequest);
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x00090BD7 File Offset: 0x0008EDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuildingUnLockRequest other)
		{
			return other != null && (other == this || (this.BuildingId == other.BuildingId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x00090C08 File Offset: 0x0008EE08
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

		// Token: 0x06003A12 RID: 14866 RVA: 0x00090C47 File Offset: 0x0008EE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x00090C54 File Offset: 0x0008EE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x00090C5D File Offset: 0x0008EE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuildingId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BuildingId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x00090C90 File Offset: 0x0008EE90
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

		// Token: 0x06003A16 RID: 14870 RVA: 0x00090CCE File Offset: 0x0008EECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuildingUnLockRequest other)
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

		// Token: 0x06003A17 RID: 14871 RVA: 0x00090CFF File Offset: 0x0008EEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x00090D08 File Offset: 0x0008EF08
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BuildingId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002BB7 RID: 11191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BB8 RID: 11192
		public const int BuildingIdFieldNumber = 4;

		// Token: 0x04002BB9 RID: 11193
		private int buildingId_;
	}
}
