using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C0 RID: 4544
	[NetMessage(EMessageId.SceneRoadSyncNotify)]
	public sealed class SceneRoadSyncNotify : IMessage<SceneRoadSyncNotify>, IMessage, IEquatable<SceneRoadSyncNotify>, IDeepCloneable<SceneRoadSyncNotify>, IBufferMessage
	{
		// Token: 0x06018435 RID: 99381 RVA: 0x00388437 File Offset: 0x00386637
		[NullableContext(1)]
		public static SceneRoadSyncNotify Create()
		{
			return new SceneRoadSyncNotify();
		}

		// Token: 0x170051C1 RID: 20929
		// (get) Token: 0x06018436 RID: 99382 RVA: 0x0038843E File Offset: 0x0038663E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051C2 RID: 20930
		// (get) Token: 0x06018437 RID: 99383 RVA: 0x00388441 File Offset: 0x00386641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneRoadSyncNotify.Descriptor;
			}
		}

		// Token: 0x06018438 RID: 99384 RVA: 0x00388448 File Offset: 0x00386648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneRoadSyncNotify()
		{
		}

		// Token: 0x06018439 RID: 99385 RVA: 0x00388468 File Offset: 0x00386668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneRoadSyncNotify(SceneRoadSyncNotify other) : this()
		{
			this.sceneId_ = other.sceneId_;
			this.instanceId_ = other.instanceId_;
			this.enabledRoads_ = other.enabledRoads_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601843A RID: 99386 RVA: 0x003884B5 File Offset: 0x003866B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneRoadSyncNotify Clone()
		{
			return new SceneRoadSyncNotify(this);
		}

		// Token: 0x170051C3 RID: 20931
		// (get) Token: 0x0601843B RID: 99387 RVA: 0x003884BD File Offset: 0x003866BD
		// (set) Token: 0x0601843C RID: 99388 RVA: 0x003884C5 File Offset: 0x003866C5
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

		// Token: 0x170051C4 RID: 20932
		// (get) Token: 0x0601843D RID: 99389 RVA: 0x003884D8 File Offset: 0x003866D8
		// (set) Token: 0x0601843E RID: 99390 RVA: 0x003884E0 File Offset: 0x003866E0
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

		// Token: 0x170051C5 RID: 20933
		// (get) Token: 0x0601843F RID: 99391 RVA: 0x003884E9 File Offset: 0x003866E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EnabledRoads
		{
			get
			{
				return this.enabledRoads_;
			}
		}

		// Token: 0x06018440 RID: 99392 RVA: 0x003884F1 File Offset: 0x003866F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneRoadSyncNotify);
		}

		// Token: 0x06018441 RID: 99393 RVA: 0x00388500 File Offset: 0x00386700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneRoadSyncNotify other)
		{
			return other != null && (other == this || (!(this.SceneId != other.SceneId) && this.InstanceId == other.InstanceId && this.enabledRoads_.Equals(other.enabledRoads_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018442 RID: 99394 RVA: 0x00388564 File Offset: 0x00386764
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

		// Token: 0x06018443 RID: 99395 RVA: 0x003885CC File Offset: 0x003867CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018444 RID: 99396 RVA: 0x003885D9 File Offset: 0x003867D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018445 RID: 99397 RVA: 0x003885E4 File Offset: 0x003867E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstanceId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstanceId);
			}
			this.enabledRoads_.WriteTo(ref output, SceneRoadSyncNotify._repeated_enabledRoads_codec);
			if (this.SceneId.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.SceneId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018446 RID: 99398 RVA: 0x00388654 File Offset: 0x00386854
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

		// Token: 0x06018447 RID: 99399 RVA: 0x003886C4 File Offset: 0x003868C4
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

		// Token: 0x06018448 RID: 99400 RVA: 0x0038872A File Offset: 0x0038692A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018449 RID: 99401 RVA: 0x00388734 File Offset: 0x00386934
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
						this.InstanceId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_45;
					}
					if (num == 90U)
					{
						this.SceneId = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.enabledRoads_.AddEntriesFrom(ref input, SceneRoadSyncNotify._repeated_enabledRoads_codec);
			}
		}

		// Token: 0x0400903F RID: 36927
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009040 RID: 36928
		public const int SceneIdFieldNumber = 11;

		// Token: 0x04009041 RID: 36929
		private string sceneId_ = "";

		// Token: 0x04009042 RID: 36930
		public const int InstanceIdFieldNumber = 1;

		// Token: 0x04009043 RID: 36931
		private int instanceId_;

		// Token: 0x04009044 RID: 36932
		public const int EnabledRoadsFieldNumber = 2;

		// Token: 0x04009045 RID: 36933
		private static readonly FieldCodec<int> _repeated_enabledRoads_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009046 RID: 36934
		private readonly RepeatedField<int> enabledRoads_ = new RepeatedField<int>();
	}
}
