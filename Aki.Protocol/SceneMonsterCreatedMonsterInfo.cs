using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011BC RID: 4540
	public sealed class SceneMonsterCreatedMonsterInfo : IMessage<SceneMonsterCreatedMonsterInfo>, IMessage, IEquatable<SceneMonsterCreatedMonsterInfo>, IDeepCloneable<SceneMonsterCreatedMonsterInfo>, IBufferMessage
	{
		// Token: 0x060183C2 RID: 99266 RVA: 0x00386D5D File Offset: 0x00384F5D
		[NullableContext(1)]
		public static SceneMonsterCreatedMonsterInfo Create()
		{
			return new SceneMonsterCreatedMonsterInfo();
		}

		// Token: 0x1700519F RID: 20895
		// (get) Token: 0x060183C3 RID: 99267 RVA: 0x00386D64 File Offset: 0x00384F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneMonsterCreatedMonsterInfo> Parser
		{
			get
			{
				return SceneMonsterCreatedMonsterInfo._parser;
			}
		}

		// Token: 0x170051A0 RID: 20896
		// (get) Token: 0x060183C4 RID: 99268 RVA: 0x00386D6B File Offset: 0x00384F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051A1 RID: 20897
		// (get) Token: 0x060183C5 RID: 99269 RVA: 0x00386D6E File Offset: 0x00384F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneMonsterCreatedMonsterInfo.Descriptor;
			}
		}

		// Token: 0x060183C6 RID: 99270 RVA: 0x00386D75 File Offset: 0x00384F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterCreatedMonsterInfo()
		{
		}

		// Token: 0x060183C7 RID: 99271 RVA: 0x00386D80 File Offset: 0x00384F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterCreatedMonsterInfo(SceneMonsterCreatedMonsterInfo other) : this()
		{
			this.prefabId_ = other.prefabId_;
			this.entityConfigId_ = other.entityConfigId_;
			this.baseLife_ = other.baseLife_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060183C8 RID: 99272 RVA: 0x00386DD4 File Offset: 0x00384FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMonsterCreatedMonsterInfo Clone()
		{
			return new SceneMonsterCreatedMonsterInfo(this);
		}

		// Token: 0x170051A2 RID: 20898
		// (get) Token: 0x060183C9 RID: 99273 RVA: 0x00386DDC File Offset: 0x00384FDC
		// (set) Token: 0x060183CA RID: 99274 RVA: 0x00386DE4 File Offset: 0x00384FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PrefabId
		{
			get
			{
				return this.prefabId_;
			}
			set
			{
				this.prefabId_ = value;
			}
		}

		// Token: 0x170051A3 RID: 20899
		// (get) Token: 0x060183CB RID: 99275 RVA: 0x00386DED File Offset: 0x00384FED
		// (set) Token: 0x060183CC RID: 99276 RVA: 0x00386DF5 File Offset: 0x00384FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x170051A4 RID: 20900
		// (get) Token: 0x060183CD RID: 99277 RVA: 0x00386DFE File Offset: 0x00384FFE
		// (set) Token: 0x060183CE RID: 99278 RVA: 0x00386E06 File Offset: 0x00385006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BaseLife
		{
			get
			{
				return this.baseLife_;
			}
			set
			{
				this.baseLife_ = value;
			}
		}

		// Token: 0x170051A5 RID: 20901
		// (get) Token: 0x060183CF RID: 99279 RVA: 0x00386E0F File Offset: 0x0038500F
		// (set) Token: 0x060183D0 RID: 99280 RVA: 0x00386E17 File Offset: 0x00385017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
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

		// Token: 0x060183D1 RID: 99281 RVA: 0x00386E20 File Offset: 0x00385020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneMonsterCreatedMonsterInfo);
		}

		// Token: 0x060183D2 RID: 99282 RVA: 0x00386E30 File Offset: 0x00385030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneMonsterCreatedMonsterInfo other)
		{
			return other != null && (other == this || (this.PrefabId == other.PrefabId && this.EntityConfigId == other.EntityConfigId && this.BaseLife == other.BaseLife && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060183D3 RID: 99283 RVA: 0x00386E9C File Offset: 0x0038509C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PrefabId != 0)
			{
				num ^= this.PrefabId.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.BaseLife != 0L)
			{
				num ^= this.BaseLife.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060183D4 RID: 99284 RVA: 0x00386F26 File Offset: 0x00385126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060183D5 RID: 99285 RVA: 0x00386F33 File Offset: 0x00385133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060183D6 RID: 99286 RVA: 0x00386F3C File Offset: 0x0038513C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PrefabId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PrefabId);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.BaseLife != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BaseLife);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060183D7 RID: 99287 RVA: 0x00386FCC File Offset: 0x003851CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PrefabId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PrefabId);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.BaseLife != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BaseLife);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060183D8 RID: 99288 RVA: 0x00387054 File Offset: 0x00385254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneMonsterCreatedMonsterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PrefabId != 0)
			{
				this.PrefabId = other.PrefabId;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.BaseLife != 0L)
			{
				this.BaseLife = other.BaseLife;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060183D9 RID: 99289 RVA: 0x003870CC File Offset: 0x003852CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060183DA RID: 99290 RVA: 0x003870D8 File Offset: 0x003852D8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.PrefabId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.BaseLife = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.State = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009008 RID: 36872
		private static readonly MessageParser<SceneMonsterCreatedMonsterInfo> _parser = new MessageParser<SceneMonsterCreatedMonsterInfo>(() => new SceneMonsterCreatedMonsterInfo());

		// Token: 0x04009009 RID: 36873
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400900A RID: 36874
		public const int PrefabIdFieldNumber = 1;

		// Token: 0x0400900B RID: 36875
		private int prefabId_;

		// Token: 0x0400900C RID: 36876
		public const int EntityConfigIdFieldNumber = 2;

		// Token: 0x0400900D RID: 36877
		private int entityConfigId_;

		// Token: 0x0400900E RID: 36878
		public const int BaseLifeFieldNumber = 3;

		// Token: 0x0400900F RID: 36879
		private long baseLife_;

		// Token: 0x04009010 RID: 36880
		public const int StateFieldNumber = 4;

		// Token: 0x04009011 RID: 36881
		private int state_;
	}
}
