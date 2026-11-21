using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001676 RID: 5750
	public static class OptionsExtensions
	{
		// Token: 0x0400C45A RID: 50266
		public static readonly Extension<MessageOptions, bool> IsMsg = new Extension<MessageOptions, bool>(1001, FieldCodec.ForBool(8008U, false));

		// Token: 0x0400C45B RID: 50267
		public static readonly Extension<MessageOptions, int> MsgID = new Extension<MessageOptions, int>(1002, FieldCodec.ForInt32(8016U, 0));

		// Token: 0x0400C45C RID: 50268
		public static readonly Extension<MessageOptions, int> ULDLMask = new Extension<MessageOptions, int>(1003, FieldCodec.ForInt32(8024U, 0));

		// Token: 0x0400C45D RID: 50269
		public static readonly Extension<MessageOptions, MSG_ROUTE_ENUM> MessageRoute = new Extension<MessageOptions, MSG_ROUTE_ENUM>(1004, FieldCodec.ForEnum<MSG_ROUTE_ENUM>(8032U, (MSG_ROUTE_ENUM x) => (int)x, (int x) => (MSG_ROUTE_ENUM)x, MSG_ROUTE_ENUM.RouteNone));

		// Token: 0x0400C45E RID: 50270
		public static readonly Extension<MessageOptions, int> Cooldown = new Extension<MessageOptions, int>(1005, FieldCodec.ForInt32(8040U, 0));

		// Token: 0x0400C45F RID: 50271
		public static readonly Extension<MessageOptions, int> NotCache = new Extension<MessageOptions, int>(1006, FieldCodec.ForInt32(8048U, 0));

		// Token: 0x0400C460 RID: 50272
		public static readonly Extension<MessageOptions, int> NetworkMask = new Extension<MessageOptions, int>(1007, FieldCodec.ForInt32(8056U, 0));

		// Token: 0x0400C461 RID: 50273
		public static readonly Extension<MessageOptions, int> MsgLock = new Extension<MessageOptions, int>(1008, FieldCodec.ForInt32(8064U, 0));

		// Token: 0x0400C462 RID: 50274
		public static readonly Extension<MessageOptions, int> NoEncrypt = new Extension<MessageOptions, int>(1009, FieldCodec.ForInt32(8072U, 0));

		// Token: 0x0400C463 RID: 50275
		public static readonly Extension<MessageOptions, int> NoReentry = new Extension<MessageOptions, int>(1010, FieldCodec.ForInt32(8080U, 0));

		// Token: 0x0400C464 RID: 50276
		public static readonly Extension<MessageOptions, int> UdpTransport = new Extension<MessageOptions, int>(1011, FieldCodec.ForInt32(8088U, 0));

		// Token: 0x0400C465 RID: 50277
		public static readonly Extension<MessageOptions, EMsgFunction> MsgFunction = new Extension<MessageOptions, EMsgFunction>(1012, FieldCodec.ForEnum<EMsgFunction>(8096U, (EMsgFunction x) => (int)x, (int x) => (EMsgFunction)x, EMsgFunction.FunctionNone));

		// Token: 0x0400C466 RID: 50278
		public static readonly Extension<MessageOptions, int> NeedShuffle = new Extension<MessageOptions, int>(1013, FieldCodec.ForInt32(8104U, 0));

		// Token: 0x0400C467 RID: 50279
		public static readonly Extension<MessageOptions, int> IsCompress = new Extension<MessageOptions, int>(1014, FieldCodec.ForInt32(8112U, 0));
	}
}
