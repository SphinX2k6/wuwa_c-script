using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001018 RID: 4120
	public sealed class RogueTowerTrialBossInfo : IMessage<RogueTowerTrialBossInfo>, IMessage, IEquatable<RogueTowerTrialBossInfo>, IDeepCloneable<RogueTowerTrialBossInfo>, IBufferMessage
	{
		// Token: 0x0601607C RID: 90236 RVA: 0x00333E73 File Offset: 0x00332073
		[NullableContext(1)]
		public static RogueTowerTrialBossInfo Create()
		{
			return new RogueTowerTrialBossInfo();
		}

		// Token: 0x170049A7 RID: 18855
		// (get) Token: 0x0601607D RID: 90237 RVA: 0x00333E7A File Offset: 0x0033207A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTowerTrialBossInfo> Parser
		{
			get
			{
				return RogueTowerTrialBossInfo._parser;
			}
		}

		// Token: 0x170049A8 RID: 18856
		// (get) Token: 0x0601607E RID: 90238 RVA: 0x00333E81 File Offset: 0x00332081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049A9 RID: 18857
		// (get) Token: 0x0601607F RID: 90239 RVA: 0x00333E84 File Offset: 0x00332084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialBossInfo.Descriptor;
			}
		}

		// Token: 0x06016080 RID: 90240 RVA: 0x00333E8B File Offset: 0x0033208B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialBossInfo()
		{
		}

		// Token: 0x06016081 RID: 90241 RVA: 0x00333E93 File Offset: 0x00332093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialBossInfo(RogueTowerTrialBossInfo other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016082 RID: 90242 RVA: 0x00333EC4 File Offset: 0x003320C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialBossInfo Clone()
		{
			return new RogueTowerTrialBossInfo(this);
		}

		// Token: 0x170049AA RID: 18858
		// (get) Token: 0x06016083 RID: 90243 RVA: 0x00333ECC File Offset: 0x003320CC
		// (set) Token: 0x06016084 RID: 90244 RVA: 0x00333ED4 File Offset: 0x003320D4
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

		// Token: 0x170049AB RID: 18859
		// (get) Token: 0x06016085 RID: 90245 RVA: 0x00333EDD File Offset: 0x003320DD
		// (set) Token: 0x06016086 RID: 90246 RVA: 0x00333EE5 File Offset: 0x003320E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialBossState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06016087 RID: 90247 RVA: 0x00333EEE File Offset: 0x003320EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialBossInfo);
		}

		// Token: 0x06016088 RID: 90248 RVA: 0x00333EFC File Offset: 0x003320FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialBossInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016089 RID: 90249 RVA: 0x00333F3C File Offset: 0x0033213C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != RogueTowerTrialBossState.IsLock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601608A RID: 90250 RVA: 0x00333F9A File Offset: 0x0033219A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601608B RID: 90251 RVA: 0x00333FA7 File Offset: 0x003321A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601608C RID: 90252 RVA: 0x00333FB0 File Offset: 0x003321B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.State != RogueTowerTrialBossState.IsLock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601608D RID: 90253 RVA: 0x00334008 File Offset: 0x00332208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.State != RogueTowerTrialBossState.IsLock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601608E RID: 90254 RVA: 0x00334060 File Offset: 0x00332260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialBossInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.State != RogueTowerTrialBossState.IsLock)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601608F RID: 90255 RVA: 0x003340B0 File Offset: 0x003322B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016090 RID: 90256 RVA: 0x003340BC File Offset: 0x003322BC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = (RogueTowerTrialBossState)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008422 RID: 33826
		private static readonly MessageParser<RogueTowerTrialBossInfo> _parser = new MessageParser<RogueTowerTrialBossInfo>(() => new RogueTowerTrialBossInfo());

		// Token: 0x04008423 RID: 33827
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008424 RID: 33828
		public const int IdFieldNumber = 1;

		// Token: 0x04008425 RID: 33829
		private int id_;

		// Token: 0x04008426 RID: 33830
		public const int StateFieldNumber = 2;

		// Token: 0x04008427 RID: 33831
		private RogueTowerTrialBossState state_;
	}
}
