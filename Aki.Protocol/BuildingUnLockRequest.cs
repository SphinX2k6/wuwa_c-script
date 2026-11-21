using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000214 RID: 532
	[NetMessage(EMessageId.BuildingUnLockRequest)]
	public sealed class BuildingUnLockRequest : IMessage<BuildingUnLockRequest>, IMessage, IEquatable<BuildingUnLockRequest>, IDeepCloneable<BuildingUnLockRequest>, IBufferMessage
	{
		// Token: 0x06003AAC RID: 15020 RVA: 0x00092786 File Offset: 0x00090986
		[NullableContext(1)]
		public static BuildingUnLockRequest Create()
		{
			return new BuildingUnLockRequest();
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06003AAD RID: 15021 RVA: 0x0009278D File Offset: 0x0009098D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06003AAE RID: 15022 RVA: 0x00092790 File Offset: 0x00090990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildingUnLockRequest.Descriptor;
			}
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x00092797 File Offset: 0x00090997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingUnLockRequest()
		{
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x0009279F File Offset: 0x0009099F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingUnLockRequest(BuildingUnLockRequest other) : this()
		{
			this.buildingId_ = other.buildingId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x000927C4 File Offset: 0x000909C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingUnLockRequest Clone()
		{
			return new BuildingUnLockRequest(this);
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06003AB2 RID: 15026 RVA: 0x000927CC File Offset: 0x000909CC
		// (set) Token: 0x06003AB3 RID: 15027 RVA: 0x000927D4 File Offset: 0x000909D4
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

		// Token: 0x06003AB4 RID: 15028 RVA: 0x000927DD File Offset: 0x000909DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildingUnLockRequest);
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x000927EB File Offset: 0x000909EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuildingUnLockRequest other)
		{
			return other != null && (other == this || (this.BuildingId == other.BuildingId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x0009281C File Offset: 0x00090A1C
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

		// Token: 0x06003AB7 RID: 15031 RVA: 0x0009285B File Offset: 0x00090A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x00092868 File Offset: 0x00090A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x00092871 File Offset: 0x00090A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuildingId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.BuildingId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x000928A4 File Offset: 0x00090AA4
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

		// Token: 0x06003ABB RID: 15035 RVA: 0x000928E2 File Offset: 0x00090AE2
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

		// Token: 0x06003ABC RID: 15036 RVA: 0x00092913 File Offset: 0x00090B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x0009291C File Offset: 0x00090B1C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BuildingId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C39 RID: 11321
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C3A RID: 11322
		public const int BuildingIdFieldNumber = 14;

		// Token: 0x04002C3B RID: 11323
		private int buildingId_;
	}
}
