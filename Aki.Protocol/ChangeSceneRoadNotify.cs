using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200025C RID: 604
	[NetMessage(EMessageId.ChangeSceneRoadNotify)]
	public sealed class ChangeSceneRoadNotify : IMessage<ChangeSceneRoadNotify>, IMessage, IEquatable<ChangeSceneRoadNotify>, IDeepCloneable<ChangeSceneRoadNotify>, IBufferMessage
	{
		// Token: 0x06004007 RID: 16391 RVA: 0x0009D410 File Offset: 0x0009B610
		[NullableContext(1)]
		public static ChangeSceneRoadNotify Create()
		{
			return new ChangeSceneRoadNotify();
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06004008 RID: 16392 RVA: 0x0009D417 File Offset: 0x0009B617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06004009 RID: 16393 RVA: 0x0009D41A File Offset: 0x0009B61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeSceneRoadNotify.Descriptor;
			}
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x0009D421 File Offset: 0x0009B621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneRoadNotify()
		{
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x0009D440 File Offset: 0x0009B640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneRoadNotify(ChangeSceneRoadNotify other) : this()
		{
			this.sceneId_ = other.sceneId_;
			this.enabledRoads_ = other.enabledRoads_.Clone();
			this.isEnable_ = other.isEnable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x0009D48D File Offset: 0x0009B68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneRoadNotify Clone()
		{
			return new ChangeSceneRoadNotify(this);
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600400D RID: 16397 RVA: 0x0009D495 File Offset: 0x0009B695
		// (set) Token: 0x0600400E RID: 16398 RVA: 0x0009D49D File Offset: 0x0009B69D
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

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x0600400F RID: 16399 RVA: 0x0009D4B0 File Offset: 0x0009B6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EnabledRoads
		{
			get
			{
				return this.enabledRoads_;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06004010 RID: 16400 RVA: 0x0009D4B8 File Offset: 0x0009B6B8
		// (set) Token: 0x06004011 RID: 16401 RVA: 0x0009D4C0 File Offset: 0x0009B6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnable
		{
			get
			{
				return this.isEnable_;
			}
			set
			{
				this.isEnable_ = value;
			}
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x0009D4C9 File Offset: 0x0009B6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeSceneRoadNotify);
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x0009D4D8 File Offset: 0x0009B6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeSceneRoadNotify other)
		{
			return other != null && (other == this || (!(this.SceneId != other.SceneId) && this.enabledRoads_.Equals(other.enabledRoads_) && this.IsEnable == other.IsEnable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x0009D53C File Offset: 0x0009B73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SceneId.Length != 0)
			{
				num ^= this.SceneId.GetHashCode();
			}
			num ^= this.enabledRoads_.GetHashCode();
			if (this.IsEnable)
			{
				num ^= this.IsEnable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x0009D5A4 File Offset: 0x0009B7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x0009D5B1 File Offset: 0x0009B7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x0009D5BC File Offset: 0x0009B7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneId.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.SceneId);
			}
			this.enabledRoads_.WriteTo(ref output, ChangeSceneRoadNotify._repeated_enabledRoads_codec);
			if (this.IsEnable)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsEnable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x0009D62C File Offset: 0x0009B82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SceneId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SceneId);
			}
			num += this.enabledRoads_.CalculateSize(ChangeSceneRoadNotify._repeated_enabledRoads_codec);
			if (this.IsEnable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x0009D690 File Offset: 0x0009B890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeSceneRoadNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SceneId.Length != 0)
			{
				this.SceneId = other.SceneId;
			}
			this.enabledRoads_.Add(other.enabledRoads_);
			if (other.IsEnable)
			{
				this.IsEnable = other.IsEnable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x0009D6F6 File Offset: 0x0009B8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x0009D700 File Offset: 0x0009B900
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
					if (num == 50U)
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
					if (num == 72U)
					{
						this.IsEnable = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.enabledRoads_.AddEntriesFrom(ref input, ChangeSceneRoadNotify._repeated_enabledRoads_codec);
			}
		}

		// Token: 0x04002D42 RID: 11586
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D43 RID: 11587
		public const int SceneIdFieldNumber = 6;

		// Token: 0x04002D44 RID: 11588
		private string sceneId_ = "";

		// Token: 0x04002D45 RID: 11589
		public const int EnabledRoadsFieldNumber = 7;

		// Token: 0x04002D46 RID: 11590
		private static readonly FieldCodec<int> _repeated_enabledRoads_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04002D47 RID: 11591
		private readonly RepeatedField<int> enabledRoads_ = new RepeatedField<int>();

		// Token: 0x04002D48 RID: 11592
		public const int IsEnableFieldNumber = 9;

		// Token: 0x04002D49 RID: 11593
		private bool isEnable_;
	}
}
