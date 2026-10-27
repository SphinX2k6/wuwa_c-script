using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000050 RID: 80
	[NetMessage(EMessageId.AccessPasserbyNpcSpawnerRequest)]
	public sealed class AccessPasserbyNpcSpawnerRequest : IMessage<AccessPasserbyNpcSpawnerRequest>, IMessage, IEquatable<AccessPasserbyNpcSpawnerRequest>, IDeepCloneable<AccessPasserbyNpcSpawnerRequest>, IBufferMessage
	{
		// Token: 0x060014D5 RID: 5333 RVA: 0x00037AB9 File Offset: 0x00035CB9
		[NullableContext(1)]
		public static AccessPasserbyNpcSpawnerRequest Create()
		{
			return new AccessPasserbyNpcSpawnerRequest();
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x00037AC0 File Offset: 0x00035CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x00037AC3 File Offset: 0x00035CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessPasserbyNpcSpawnerRequest.Descriptor;
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00037ACA File Offset: 0x00035CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPasserbyNpcSpawnerRequest()
		{
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00037AD2 File Offset: 0x00035CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPasserbyNpcSpawnerRequest(AccessPasserbyNpcSpawnerRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.splineConfigId_ = other.splineConfigId_;
			this.isSplneNotValid_ = other.isSplneNotValid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00037B0F File Offset: 0x00035D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPasserbyNpcSpawnerRequest Clone()
		{
			return new AccessPasserbyNpcSpawnerRequest(this);
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00037B17 File Offset: 0x00035D17
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x00037B1F File Offset: 0x00035D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00037B28 File Offset: 0x00035D28
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x00037B30 File Offset: 0x00035D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineConfigId
		{
			get
			{
				return this.splineConfigId_;
			}
			set
			{
				this.splineConfigId_ = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x00037B39 File Offset: 0x00035D39
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x00037B41 File Offset: 0x00035D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSplneNotValid
		{
			get
			{
				return this.isSplneNotValid_;
			}
			set
			{
				this.isSplneNotValid_ = value;
			}
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00037B4A File Offset: 0x00035D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessPasserbyNpcSpawnerRequest);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00037B58 File Offset: 0x00035D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessPasserbyNpcSpawnerRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SplineConfigId == other.SplineConfigId && this.IsSplneNotValid == other.IsSplneNotValid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x00037BB4 File Offset: 0x00035DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SplineConfigId != 0)
			{
				num ^= this.SplineConfigId.GetHashCode();
			}
			if (this.IsSplneNotValid)
			{
				num ^= this.IsSplneNotValid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00037C25 File Offset: 0x00035E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00037C32 File Offset: 0x00035E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00037C3C File Offset: 0x00035E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SplineConfigId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SplineConfigId);
			}
			if (this.IsSplneNotValid)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsSplneNotValid);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00037CB4 File Offset: 0x00035EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SplineConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineConfigId);
			}
			if (this.IsSplneNotValid)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00037D18 File Offset: 0x00035F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AccessPasserbyNpcSpawnerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SplineConfigId != 0)
			{
				this.SplineConfigId = other.SplineConfigId;
			}
			if (other.IsSplneNotValid)
			{
				this.IsSplneNotValid = other.IsSplneNotValid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00037D7C File Offset: 0x00035F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00037D88 File Offset: 0x00035F88
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
				if (num != 56U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityId = input.ReadInt64();
						}
					}
					else
					{
						this.IsSplneNotValid = input.ReadBool();
					}
				}
				else
				{
					this.SplineConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002079 RID: 8313
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400207A RID: 8314
		public const int EntityIdFieldNumber = 15;

		// Token: 0x0400207B RID: 8315
		private long entityId_;

		// Token: 0x0400207C RID: 8316
		public const int SplineConfigIdFieldNumber = 7;

		// Token: 0x0400207D RID: 8317
		private int splineConfigId_;

		// Token: 0x0400207E RID: 8318
		public const int IsSplneNotValidFieldNumber = 10;

		// Token: 0x0400207F RID: 8319
		private bool isSplneNotValid_;
	}
}
