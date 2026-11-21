using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001366 RID: 4966
	[NetMessage(EMessageId.SwitchBattleModeRequest)]
	public sealed class SwitchBattleModeRequest : IMessage<SwitchBattleModeRequest>, IMessage, IEquatable<SwitchBattleModeRequest>, IDeepCloneable<SwitchBattleModeRequest>, IBufferMessage
	{
		// Token: 0x0601A730 RID: 108336 RVA: 0x003DAA11 File Offset: 0x003D8C11
		[NullableContext(1)]
		public static SwitchBattleModeRequest Create()
		{
			return new SwitchBattleModeRequest();
		}

		// Token: 0x1700598C RID: 22924
		// (get) Token: 0x0601A731 RID: 108337 RVA: 0x003DAA18 File Offset: 0x003D8C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700598D RID: 22925
		// (get) Token: 0x0601A732 RID: 108338 RVA: 0x003DAA1B File Offset: 0x003D8C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchBattleModeRequest.Descriptor;
			}
		}

		// Token: 0x0601A733 RID: 108339 RVA: 0x003DAA22 File Offset: 0x003D8C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeRequest()
		{
		}

		// Token: 0x0601A734 RID: 108340 RVA: 0x003DAA2A File Offset: 0x003D8C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeRequest(SwitchBattleModeRequest other) : this()
		{
			this.client_ = other.client_;
			this.clientControllerModule_ = other.clientControllerModule_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A735 RID: 108341 RVA: 0x003DAA5B File Offset: 0x003D8C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeRequest Clone()
		{
			return new SwitchBattleModeRequest(this);
		}

		// Token: 0x1700598E RID: 22926
		// (get) Token: 0x0601A736 RID: 108342 RVA: 0x003DAA63 File Offset: 0x003D8C63
		// (set) Token: 0x0601A737 RID: 108343 RVA: 0x003DAA6B File Offset: 0x003D8C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Client
		{
			get
			{
				return this.client_;
			}
			set
			{
				this.client_ = value;
			}
		}

		// Token: 0x1700598F RID: 22927
		// (get) Token: 0x0601A738 RID: 108344 RVA: 0x003DAA74 File Offset: 0x003D8C74
		// (set) Token: 0x0601A739 RID: 108345 RVA: 0x003DAA7C File Offset: 0x003D8C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleModule ClientControllerModule
		{
			get
			{
				return this.clientControllerModule_;
			}
			set
			{
				this.clientControllerModule_ = value;
			}
		}

		// Token: 0x0601A73A RID: 108346 RVA: 0x003DAA85 File Offset: 0x003D8C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchBattleModeRequest);
		}

		// Token: 0x0601A73B RID: 108347 RVA: 0x003DAA93 File Offset: 0x003D8C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchBattleModeRequest other)
		{
			return other != null && (other == this || (this.Client == other.Client && this.ClientControllerModule == other.ClientControllerModule && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A73C RID: 108348 RVA: 0x003DAAD4 File Offset: 0x003D8CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Client)
			{
				num ^= this.Client.GetHashCode();
			}
			if (this.ClientControllerModule != BattleModule.Damage)
			{
				num ^= this.ClientControllerModule.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A73D RID: 108349 RVA: 0x003DAB32 File Offset: 0x003D8D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A73E RID: 108350 RVA: 0x003DAB3F File Offset: 0x003D8D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A73F RID: 108351 RVA: 0x003DAB48 File Offset: 0x003D8D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Client)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Client);
			}
			if (this.ClientControllerModule != BattleModule.Damage)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ClientControllerModule);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A740 RID: 108352 RVA: 0x003DABA4 File Offset: 0x003D8DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Client)
			{
				num += 2;
			}
			if (this.ClientControllerModule != BattleModule.Damage)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ClientControllerModule);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A741 RID: 108353 RVA: 0x003DABF0 File Offset: 0x003D8DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchBattleModeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Client)
			{
				this.Client = other.Client;
			}
			if (other.ClientControllerModule != BattleModule.Damage)
			{
				this.ClientControllerModule = other.ClientControllerModule;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A742 RID: 108354 RVA: 0x003DAC40 File Offset: 0x003D8E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A743 RID: 108355 RVA: 0x003DAC4C File Offset: 0x003D8E4C
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
				if (num != 40U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ClientControllerModule = (BattleModule)input.ReadEnum();
					}
				}
				else
				{
					this.Client = input.ReadBool();
				}
			}
		}

		// Token: 0x04009B2E RID: 39726
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B2F RID: 39727
		public const int ClientFieldNumber = 5;

		// Token: 0x04009B30 RID: 39728
		private bool client_;

		// Token: 0x04009B31 RID: 39729
		public const int ClientControllerModuleFieldNumber = 15;

		// Token: 0x04009B32 RID: 39730
		private BattleModule clientControllerModule_;
	}
}
