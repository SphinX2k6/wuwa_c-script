using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001186 RID: 4486
	[NetMessage(EMessageId.SceneRoadSyncNotify)]
	public sealed class SceneRoadSyncNotify : IMessage<SceneRoadSyncNotify>, IMessage, IEquatable<SceneRoadSyncNotify>, IDeepCloneable<SceneRoadSyncNotify>, IBufferMessage
	{
		// Token: 0x06017E94 RID: 97940 RVA: 0x003790F3 File Offset: 0x003772F3
		[NullableContext(1)]
		public static SceneRoadSyncNotify Create()
		{
			return new SceneRoadSyncNotify();
		}

		// Token: 0x17005055 RID: 20565
		// (get) Token: 0x06017E95 RID: 97941 RVA: 0x003790FA File Offset: 0x003772FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005056 RID: 20566
		// (get) Token: 0x06017E96 RID: 97942 RVA: 0x003790FD File Offset: 0x003772FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneRoadSyncNotify.Descriptor;
			}
		}

		// Token: 0x06017E97 RID: 97943 RVA: 0x00379104 File Offset: 0x00377304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneRoadSyncNotify()
		{
		}

		// Token: 0x06017E98 RID: 97944 RVA: 0x00379124 File Offset: 0x00377324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneRoadSyncNotify(SceneRoadSyncNotify other) : this()
		{
			this.sceneId_ = other.sceneId_;
			this.instanceId_ = other.instanceId_;
			this.enabledRoads_ = other.enabledRoads_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E99 RID: 97945 RVA: 0x00379171 File Offset: 0x00377371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneRoadSyncNotify Clone()
		{
			return new SceneRoadSyncNotify(this);
		}

		// Token: 0x17005057 RID: 20567
		// (get) Token: 0x06017E9A RID: 97946 RVA: 0x00379179 File Offset: 0x00377379
		// (set) Token: 0x06017E9B RID: 97947 RVA: 0x00379181 File Offset: 0x00377381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SceneId
		{
			get
			{
				return this.sceneId_;
			}
			set
			{
				this.sceneId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005058 RID: 20568
		// (get) Token: 0x06017E9C RID: 97948 RVA: 0x00379194 File Offset: 0x00377394
		// (set) Token: 0x06017E9D RID: 97949 RVA: 0x0037919C File Offset: 0x0037739C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstanceId
		{
			get
			{
				return this.instanceId_;
			}
			set
			{
				this.instanceId_ = value;
			}
		}

		// Token: 0x17005059 RID: 20569
		// (get) Token: 0x06017E9E RID: 97950 RVA: 0x003791A5 File Offset: 0x003773A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EnabledRoads
		{
			get
			{
				return this.enabledRoads_;
			}
		}

		// Token: 0x06017E9F RID: 97951 RVA: 0x003791AD File Offset: 0x003773AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneRoadSyncNotify);
		}

		// Token: 0x06017EA0 RID: 97952 RVA: 0x003791BC File Offset: 0x003773BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneRoadSyncNotify other)
		{
			return other != null && (other == this || (!(this.SceneId != other.SceneId) && this.InstanceId == other.InstanceId && this.enabledRoads_.Equals(other.enabledRoads_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017EA1 RID: 97953 RVA: 0x00379220 File Offset: 0x00377420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SceneId.Length != 0)
			{
				num ^= this.SceneId.GetHashCode();
			}
			if (this.InstanceId != 0)
			{
				num ^= this.InstanceId.GetHashCode();
			}
			num ^= this.enabledRoads_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017EA2 RID: 97954 RVA: 0x00379288 File Offset: 0x00377488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017EA3 RID: 97955 RVA: 0x00379295 File Offset: 0x00377495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017EA4 RID: 97956 RVA: 0x003792A0 File Offset: 0x003774A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.SceneId);
			}
			this.enabledRoads_.WriteTo(ref output, SceneRoadSyncNotify._repeated_enabledRoads_codec);
			if (this.InstanceId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstanceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017EA5 RID: 97957 RVA: 0x00379310 File Offset: 0x00377510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SceneId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SceneId);
			}
			if (this.InstanceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstanceId);
			}
			num += this.enabledRoads_.CalculateSize(SceneRoadSyncNotify._repeated_enabledRoads_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017EA6 RID: 97958 RVA: 0x00379380 File Offset: 0x00377580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneRoadSyncNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SceneId.Length != 0)
			{
				this.SceneId = other.SceneId;
			}
			if (other.InstanceId != 0)
			{
				this.InstanceId = other.InstanceId;
			}
			this.enabledRoads_.Add(other.enabledRoads_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017EA7 RID: 97959 RVA: 0x003793E6 File Offset: 0x003775E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017EA8 RID: 97960 RVA: 0x003793F0 File Offset: 0x003775F0
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
				if (num <= 56U)
				{
					if (num == 18U)
					{
						this.SceneId = input.ReadString();
						continue;
					}
					if (num == 56U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 58U)
					{
						goto IL_46;
					}
					if (num == 120U)
					{
						this.InstanceId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.enabledRoads_.AddEntriesFrom(ref input, SceneRoadSyncNotify._repeated_enabledRoads_codec);
			}
		}

		// Token: 0x04008DAC RID: 36268
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DAD RID: 36269
		public const int SceneIdFieldNumber = 2;

		// Token: 0x04008DAE RID: 36270
		private string sceneId_ = "";

		// Token: 0x04008DAF RID: 36271
		public const int InstanceIdFieldNumber = 15;

		// Token: 0x04008DB0 RID: 36272
		private int instanceId_;

		// Token: 0x04008DB1 RID: 36273
		public const int EnabledRoadsFieldNumber = 7;

		// Token: 0x04008DB2 RID: 36274
		private static readonly FieldCodec<int> _repeated_enabledRoads_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04008DB3 RID: 36275
		private readonly RepeatedField<int> enabledRoads_ = new RepeatedField<int>();
	}
}
