using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A9 RID: 5033
	[NetMessage(EMessageId.TowerDefenceRandListRequest)]
	public sealed class TowerDefenceRandListRequest : IMessage<TowerDefenceRandListRequest>, IMessage, IEquatable<TowerDefenceRandListRequest>, IDeepCloneable<TowerDefenceRandListRequest>, IBufferMessage
	{
		// Token: 0x0601AB47 RID: 109383 RVA: 0x003DF8A4 File Offset: 0x003DDAA4
		[NullableContext(1)]
		public static TowerDefenceRandListRequest Create()
		{
			return new TowerDefenceRandListRequest();
		}

		// Token: 0x17005A0E RID: 23054
		// (get) Token: 0x0601AB48 RID: 109384 RVA: 0x003DF8AB File Offset: 0x003DDAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A0F RID: 23055
		// (get) Token: 0x0601AB49 RID: 109385 RVA: 0x003DF8AE File Offset: 0x003DDAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRandListRequest.Descriptor;
			}
		}

		// Token: 0x0601AB4A RID: 109386 RVA: 0x003DF8B5 File Offset: 0x003DDAB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRandListRequest()
		{
		}

		// Token: 0x0601AB4B RID: 109387 RVA: 0x003DF8BD File Offset: 0x003DDABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRandListRequest(TowerDefenceRandListRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB4C RID: 109388 RVA: 0x003DF8E2 File Offset: 0x003DDAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRandListRequest Clone()
		{
			return new TowerDefenceRandListRequest(this);
		}

		// Token: 0x17005A10 RID: 23056
		// (get) Token: 0x0601AB4D RID: 109389 RVA: 0x003DF8EA File Offset: 0x003DDAEA
		// (set) Token: 0x0601AB4E RID: 109390 RVA: 0x003DF8F2 File Offset: 0x003DDAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0601AB4F RID: 109391 RVA: 0x003DF8FB File Offset: 0x003DDAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRandListRequest);
		}

		// Token: 0x0601AB50 RID: 109392 RVA: 0x003DF909 File Offset: 0x003DDB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRandListRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB51 RID: 109393 RVA: 0x003DF938 File Offset: 0x003DDB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AB52 RID: 109394 RVA: 0x003DF977 File Offset: 0x003DDB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB53 RID: 109395 RVA: 0x003DF984 File Offset: 0x003DDB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB54 RID: 109396 RVA: 0x003DF98D File Offset: 0x003DDB8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB55 RID: 109397 RVA: 0x003DF9C0 File Offset: 0x003DDBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AB56 RID: 109398 RVA: 0x003DF9FE File Offset: 0x003DDBFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceRandListRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AB57 RID: 109399 RVA: 0x003DFA2F File Offset: 0x003DDC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB58 RID: 109400 RVA: 0x003DFA38 File Offset: 0x003DDC38
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009B1B RID: 39707
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B1C RID: 39708
		public const int IdFieldNumber = 15;

		// Token: 0x04009B1D RID: 39709
		private int id_;
	}
}
