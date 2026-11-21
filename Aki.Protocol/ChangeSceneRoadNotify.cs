using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000261 RID: 609
	[NetMessage(EMessageId.ChangeSceneRoadNotify)]
	public sealed class ChangeSceneRoadNotify : IMessage<ChangeSceneRoadNotify>, IMessage, IEquatable<ChangeSceneRoadNotify>, IDeepCloneable<ChangeSceneRoadNotify>, IBufferMessage
	{
		// Token: 0x060040AE RID: 16558 RVA: 0x0009F0DC File Offset: 0x0009D2DC
		[NullableContext(1)]
		public static ChangeSceneRoadNotify Create()
		{
			return new ChangeSceneRoadNotify();
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x060040AF RID: 16559 RVA: 0x0009F0E3 File Offset: 0x0009D2E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x060040B0 RID: 16560 RVA: 0x0009F0E6 File Offset: 0x0009D2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeSceneRoadNotify.Descriptor;
			}
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x0009F0ED File Offset: 0x0009D2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneRoadNotify()
		{
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x0009F10C File Offset: 0x0009D30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneRoadNotify(ChangeSceneRoadNotify other) : this()
		{
			this.sceneId_ = other.sceneId_;
			this.enabledRoads_ = other.enabledRoads_.Clone();
			this.isEnable_ = other.isEnable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x0009F159 File Offset: 0x0009D359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneRoadNotify Clone()
		{
			return new ChangeSceneRoadNotify(this);
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x0009F161 File Offset: 0x0009D361
		// (set) Token: 0x060040B5 RID: 16565 RVA: 0x0009F169 File Offset: 0x0009D369
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

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060040B6 RID: 16566 RVA: 0x0009F17C File Offset: 0x0009D37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EnabledRoads
		{
			get
			{
				return this.enabledRoads_;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060040B7 RID: 16567 RVA: 0x0009F184 File Offset: 0x0009D384
		// (set) Token: 0x060040B8 RID: 16568 RVA: 0x0009F18C File Offset: 0x0009D38C
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

		// Token: 0x060040B9 RID: 16569 RVA: 0x0009F195 File Offset: 0x0009D395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeSceneRoadNotify);
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x0009F1A4 File Offset: 0x0009D3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeSceneRoadNotify other)
		{
			return other != null && (other == this || (!(this.SceneId != other.SceneId) && this.enabledRoads_.Equals(other.enabledRoads_) && this.IsEnable == other.IsEnable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x0009F208 File Offset: 0x0009D408
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

		// Token: 0x060040BC RID: 16572 RVA: 0x0009F270 File Offset: 0x0009D470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x0009F27D File Offset: 0x0009D47D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x0009F288 File Offset: 0x0009D488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsEnable)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsEnable);
			}
			this.enabledRoads_.WriteTo(ref output, ChangeSceneRoadNotify._repeated_enabledRoads_codec);
			if (this.SceneId.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.SceneId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x0009F2F8 File Offset: 0x0009D4F8
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

		// Token: 0x060040C0 RID: 16576 RVA: 0x0009F35C File Offset: 0x0009D55C
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

		// Token: 0x060040C1 RID: 16577 RVA: 0x0009F3C2 File Offset: 0x0009D5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x0009F3CC File Offset: 0x0009D5CC
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
				if (num <= 88U)
				{
					if (num == 48U)
					{
						this.IsEnable = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 90U)
					{
						goto IL_46;
					}
					if (num == 114U)
					{
						this.SceneId = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.enabledRoads_.AddEntriesFrom(ref input, ChangeSceneRoadNotify._repeated_enabledRoads_codec);
			}
		}

		// Token: 0x04002DC6 RID: 11718
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DC7 RID: 11719
		public const int SceneIdFieldNumber = 14;

		// Token: 0x04002DC8 RID: 11720
		private string sceneId_ = "";

		// Token: 0x04002DC9 RID: 11721
		public const int EnabledRoadsFieldNumber = 11;

		// Token: 0x04002DCA RID: 11722
		private static readonly FieldCodec<int> _repeated_enabledRoads_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04002DCB RID: 11723
		private readonly RepeatedField<int> enabledRoads_ = new RepeatedField<int>();

		// Token: 0x04002DCC RID: 11724
		public const int IsEnableFieldNumber = 6;

		// Token: 0x04002DCD RID: 11725
		private bool isEnable_;
	}
}
